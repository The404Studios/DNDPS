using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DC.Packet;

namespace SVERA.Handlers
{
    public static class InventoryHandler
    {
        private static List<(Item, List<ItemAttribute>)> GetAllItems(int characterId, Define_Item.InventoryId? inventoryId = null, Define_Equipment.SlotId? slotId = null)
        {
            using var db = new SVERA();

            var query = db.Items
                .Where(i => i.CharacterId == characterId && i.Index == 0);

            if (inventoryId.HasValue)
                query = query.Where(i => i.InventoryId == inventoryId.Value);

            if (slotId.HasValue)
                query = query.Where(i => i.SlotId == slotId.Value);

            var result = new List<(Item, List<ItemAttribute>)>();

            foreach (var item in query.ToList())
            {
                var attributes = db.ItemAttributes.Where(a => a.ItemId == item.Id).ToList();
                result.Add((item, attributes));
            }

            return result;
        }

        private static bool DeleteItem(int characterId, Item item, bool isQuery = false)
        {
            using var db = new SVERA();

            Item query;

            if (isQuery)
                query = item;
            else
                query = db.Items.FirstOrDefault(i => i.CharacterId == characterId && i.Id == item.ItemUniqueId);

            if (query == null)
                return false;

            var attributes = db.ItemAttributes.Where(a => a.ItemId == query.Id).ToList();
            db.ItemAttributes.RemoveRange(attributes);
            db.Items.Remove(query);

            db.SaveChanges();

            return true;
        }

        private static void AddItem((Item, List<ItemAttribute>) itemTuple)
        {
            using var db = new SVERA();

            var (item, attributes) = itemTuple;

            db.Items.Add(item);

            foreach (var attribute in attributes)
                db.ItemAttributes.Add(attribute);

            db.SaveChanges();
        }

        private static int GetStackLimit(string item)
        {
            if (item.Contains("Id_Item_Bandage") || item.Contains("Potion") || item.Contains("Id_Item_ThrowingKnife"))
                return 3;
            if (item.Contains("Id_Item_GoldCoinPurse") || item.Contains("Id_Item_GoldCoinChest") || item.Contains("Id_Item_GoldCoinBag"))
                return 1;
            if (item.Contains("Id_Item_GoldCoins") || item.Contains("Id_Item_SilverCoin"))
                return 10;
            if (item.Contains("Id_Item_Arrow"))
                return 15;
            return 0;
        }

        private static int GetInvLimit(string item)
        {
            if (item.Contains("Id_Item_GoldCoinPurse"))
                return 50;
            if (item.Contains("Id_Item_GoldCoinBag"))
                return 200;
            if (item.Contains("Id_Item_GoldCoinChest"))
                return 1000;
            return 0;
        }

        private static int SplitItem(Item fromItem, string itemId, Define_Item.InventoryId toInventory, Define_Equipment.SlotId toSlot, int quantity, int characterId, bool fromIsPersistent = true)
        {
            var newItem = new Item
            {
                CharacterId = characterId,
                InventoryId = toInventory,
                SlotId = toSlot,
                Quantity = quantity
            };
            var attributes = new List<ItemAttribute>();

            using (var db = new SVERA())
            {
                if (GetInvLimit(fromItem.ItemId) > 0)
                {
                    fromItem.InvCount -= quantity;
                    newItem.ItemId = itemId;
                }
                else
                {
                    fromItem.Quantity -= quantity;
                    newItem.ItemId = fromItem.ItemId;

                    var itemAttributes = db.ItemAttributes.Where(a => a.ItemId == fromItem.Id).ToList();
                    foreach (var attribute in itemAttributes)
                    {
                        attributes.Add(new ItemAttribute
                        {
                            ItemId = attribute.ItemId,
                            Primary = attribute.Primary,
                            Property = attribute.Property,
                            Value = attribute.Value
                        });
                    }
                }

                AddItem((newItem, attributes));

                if (fromItem.Quantity <= 0 && fromIsPersistent)
                {
                    DeleteItem(characterId, fromItem, true);
                }

                return newItem.Id;
            }
        }

        private static bool MergeItems(Item fromItem, Item toItem, int amount, int characterId, bool fromIsPersistent = true)
        {
            using var db = new SVERA();

            if (GetInvLimit(fromItem.ItemId) > 0 && GetInvLimit(toItem.ItemId) > 0)
            {
                var limit = GetInvLimit(toItem.ItemId);
                var total = toItem.InvCount + amount;
                toItem.InvCount = Math.Min(total, limit);
                fromItem.InvCount -= total <= limit ? amount : total - limit;
                return true;
            }

            if (GetInvLimit(toItem.ItemId) > 0)
            {
                var limit = GetInvLimit(toItem.ItemId);
                var total = toItem.InvCount + amount;
                toItem.InvCount = Math.Min(total, limit);
                fromItem.Quantity -= total <= limit ? amount : total - limit;
            }
            else if (GetStackLimit(toItem.ItemId) > 0)
            {
                var limit = GetStackLimit(toItem.ItemId);
                var total = toItem.Quantity + amount;
                toItem.Quantity = Math.Min(total, limit);
                fromItem.Quantity -= total <= limit ? amount : total - limit;
            }
            else
            {
                return false;
            }

            if (fromItem.Quantity <= 0 && fromIsPersistent)
            {
                DeleteItem(characterId, fromItem, true);
            }

            return true;
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES MergeRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_MERGE_REQ.Parser.ParseFrom(msg);

            using var db = new SVERA();
            var character = sessions[ctx.Transport].Character;

            var old = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.SrcInfo.UniqueId);
            var newItem = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.DstInfo.UniqueId);

            if (old != null && newItem != null)
            {
                var amount = old.InvCount > 0 ? old.InvCount : old.Quantity;
                MergeItems(old, newItem, amount, character.Id);
            }

            ctx.Reply(new SS2C_INVENTORY_MERGE_RES());
            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES SplitMoveRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_SPLIT_MOVE_REQ.Parser.ParseFrom(msg);

            using var db = new SVERA();
            var item = db.Items.FirstOrDefault(i => i.CharacterId == sessions[ctx.Transport].Character.Id && i.Id == req.SrcInfo.UniqueId);

            var res = new SS2C_INVENTORY_SPLIT_MOVE_RES();

            if (GetInvLimit(item.ItemId) > 0)
            {
                res.NewUniqueId = SplitItem(item, "DesignDataItem:Id_Item_GoldCoins", req.DstInventoryId, req.DstSlotId, req.Count, sessions[ctx.Transport].Character.Id);
            }
            else
            {
                res.NewUniqueId = SplitItem(item, item.ItemId, req.DstInventoryId, req.DstSlotId, req.Count, sessions[ctx.Transport].Character.Id);
            }

            res.NewInventoryId = req.DstInventoryId;
            res.NewSlotId = req.DstSlotId;

            ctx.Reply(res);
            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES SwapRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_SWAP_REQ.Parser.ParseFrom(msg);

            using var db = new SVERA();
            var character = sessions[ctx.Transport].Character;

            var it = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.SrcInfo.UniqueId);
            if (it != null)
            {
                it.InventoryId = req.DstInfo.InventoryId;
                it.SlotId = req.DstInfo.SlotId;
            }

            foreach (var item in req.SwapInfos)
            {
                it = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == item.DstInfo.UniqueId);
                if (it != null)
                {
                    it.InventoryId = item.NewInventoryId;
                    it.SlotId = item.NewSlotId;
                }
            }

            ctx.Reply(new SS2C_INVENTORY_SWAP_RES());
            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES SplitMergeRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_SPLIT_MERGE_REQ.Parser.ParseFrom(msg);

            using var db = new SVERA();
            var character = sessions[ctx.Transport].Character;

            var old = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.SrcInfo.UniqueId);
            var newItem = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.DstInfo.UniqueId);

            if (old != null && newItem != null)
            {
                var tempItem = new Item
                {
                    ItemId = old.ItemId,
                    AmmoCount = old.AmmoCount,
                    Quantity = GetInvLimit(old.ItemId) > 0 ? req.Count : old.Quantity - req.Count
                };

                if (MergeItems(tempItem, newItem, req.Count, character.Id, false))
                {
                    if (GetInvLimit(tempItem.ItemId) > 0)
                    {
                        old.InvCount -= req.Count;
                    }
                    else
                    {
                        old.Quantity -= req.Count;
                    }
                }
            }

            ctx.Reply(new SS2C_INVENTORY_SPLIT_MERGE_RES());
            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES MoveRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_MOVE_REQ.Parser.ParseFrom(msg);

            using var db = new SVERA();
            var character = db.Characters.FirstOrDefault(c => c.Id == sessions[ctx.Transport].Character.Id);

            if (character != null)
            {
                var item = db.Items.FirstOrDefault(i => i.CharacterId == character.Id && i.Id == req.SrcInfo.UniqueId && i.Index == 0);
                if (item != null)
                {
                    item.InventoryId = req.DstInventoryId;
                    item.SlotId = req.DstSlotId;
                }
            }

            ctx.Reply(new SS2C_INVENTORY_MOVE_RES());
            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES MoveSingleRequest(SVERAServer ctx, byte[] msg)
        {
            var req = SC2S_INVENTORY_SINGLE_UPDATE_REQ.Parser.ParseFrom(msg);

            if (req.SingleUpdateFlag != 0)
            {
                return new SS2C_INVENTORY_SINGLE_UPDATE_RES
                {
                    Result = PacketCommand.SUCCESS,
                    OldItem = req.OldItem,
                    NewItem = req.NewItem
                };
            }

            using var db = new SVERA();
            var character = sessions[ctx.Transport].Character;

            foreach (var (old, newItem) in req.OldItem.Zip(req.NewItem))
            {
                var oldQuery = db.Items
                    .FirstOrDefault(i => i.CharacterId == character.Id && i.Id == old.ItemUniqueId && i.ItemId == old.ItemId && i.Index == 0);

                if (oldQuery == null)
                    continue;

                if (old.ItemUniqueId == newItem.ItemUniqueId)
                {
                    oldQuery.InventoryId = newItem.InventoryId;
                    oldQuery.SlotId = newItem.SlotId;
                    continue;
                }

                var newQuery = db.Items
                    .FirstOrDefault(i => i.CharacterId == character.Id && i.Id == newItem.ItemUniqueId && i.SlotId == newItem.SlotId && i.InventoryId == newItem.InventoryId);

                if (newQuery == null)
                {
                    newItem.ItemUniqueId = SplitItem(oldQuery, newItem.ItemId, newItem.InventoryId, newItem.SlotId, newItem.ItemCount, character.Id);
                }
                else
                {
                    var amount = newItem.ItemContentsCount > 0 ? newItem.ItemContentsCount : newItem.ItemCount;

                    if (!MergeItems(oldQuery, newQuery, amount, character.Id))
                    {
                        return new SS2C_INVENTORY_SINGLE_UPDATE_RES
                        {
                            Result = PacketCommand.FAIL_NO_VALUE,
                            OldItem = req.OldItem,
                            NewItem = req.NewItem
                        };
                    }
                }
            }

            ctx.Reply(new SS2C_INVENTORY_SINGLE_UPDATE_RES
            {
                Result = PacketCommand.SUCCESS,
                OldItem = req.OldItem,
                NewItem = req.NewItem
            });

            return HCharacter.CharacterInfo(ctx, new byte[0]);
        }
    }
}
