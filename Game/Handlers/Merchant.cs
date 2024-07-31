using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using DC.Packet;

namespace YourNamespace.Services
{
    public static class MerchantService
    {
        public static void DeleteItemsMerchant(int merchantId)
        {
            var items = DbContext.Items.Where(i => i.MerchantId == merchantId).ToList();

            foreach (var item in items)
            {
                // Get the attributes for the item
                var attributes = DbContext.ItemAttributes.Where(a => a.ItemId == item.Id).ToList();

                foreach (var attribute in attributes)
                {
                    DbContext.ItemAttributes.Remove(attribute);
                }

                DbContext.Items.Remove(item);
            }

            DbContext.SaveChanges();
        }

        public static void DeleteMerchants(int characterId)
        {
            var merchants = DbContext.Merchants.Where(m => m.CharacterId == characterId).ToList();

            foreach (var merchant in merchants)
            {
                DeleteItemsMerchant(merchant.Id);
                DbContext.Merchants.Remove(merchant);
            }

            DbContext.SaveChanges();
        }

        public static void CreateMerchants(int characterId)
        {
            foreach (var merchantClass in Enum.GetValues(typeof(MerchantClass)).Cast<MerchantClass>())
            {
                DbCreateMerchant(characterId, merchantClass, DateTime.UtcNow.AddMinutes(15));
            }
        }

        public static string GetStockBuyId(MerchantClass merchantClass, int index)
        {
            var prefix = merchantClass switch
            {
                MerchantClass.Surgeon => "Surgeon",
                MerchantClass.Santa => "Santa",
                MerchantClass.Woodsman => "Woodsman",
                MerchantClass.Tailor => "Tailor",
                MerchantClass.Treasurer => "Treasurer",
                MerchantClass.Leathersmith => "Leathersmith",
                MerchantClass.Armourer => "Armourer",
                MerchantClass.TheCollector => "Pickaxe",
                MerchantClass.Alchemist => "Alchemist",
                MerchantClass.TavernMaster => "TavernMaster",
                MerchantClass.Weaponsmith => "Weaponsmith",
                MerchantClass.GoblinMerchant => "GoblinMerchant",
                MerchantClass.Valentine => "Valentine",
                MerchantClass.PumpkinMan => "PumpkinMan",
                _ => throw new ArgumentOutOfRangeException()
            };

            return $"DesignDataStockBuy:Id_StockBuy_{prefix}_{index:D2}";
        }

        public static int GetStockUniqueId(MerchantClass merchantClass, int index)
        {
            // TODO: Implement mapping for stock unique id if necessary
            return index;
        }

        public static void DbCreateMerchant(int characterId, MerchantClass merchantClass, DateTime refreshTime)
        {
            var merchant = new Merchant
            {
                CharacterId = characterId,
                Merchant = merchantClass,
                RefreshTime = refreshTime
            };

            DbContext.Merchants.Add(merchant);
            DbContext.SaveChanges();
        }

        public static void DbCreateMerchantItem(int merchantId, SItem item, int index, DateTime remaining, int characterId)
        {
            var newItem = new Item
            {
                CharacterId = characterId,
                MerchantId = merchantId,
                Remaining = remaining,
                Index = index,
                ItemId = item.ItemId,
                Quantity = item.ItemCount,
                AmmoCount = item.ItemAmmoCount,
                InvCount = item.ItemContentsCount
            };

            DbContext.Items.Add(newItem);
            DbContext.SaveChanges();

            // Add attributes
            foreach (var attribute in item.PrimaryPropertyArray)
            {
                var attr = new ItemAttribute
                {
                    ItemId = newItem.Id,
                    Primary = true,
                    Property = attribute.PropertyTypeId,
                    Value = attribute.PropertyValue
                };

                DbContext.ItemAttributes.Add(attr);
            }

            foreach (var attribute in item.SecondaryPropertyArray)
            {
                var attr = new ItemAttribute
                {
                    ItemId = newItem.Id,
                    Primary = false,
                    Property = attribute.PropertyTypeId,
                    Value = attribute.PropertyValue
                };

                DbContext.ItemAttributes.Add(attr);
            }

            DbContext.SaveChanges();
        }

        public static void GenerateItemsMerchant(MerchantClass merchantClass, int merchantId, int characterId)
        {
            var items = ObjItems.GenerateMerchItems(merchantClass);
            var merchantMap = MerchantData.BuyMapping[merchantClass];

            foreach (var (index, variations) in merchantMap.Zip(items))
            {
                var (item, remaining) = variations;
                DbCreateMerchantItem(merchantId, item, index, DateTime.UtcNow.AddMinutes(15), characterId);
            }
        }

        public static bool AddToInventoryMerchant(int uniqueId, SMERCHANT_TRADE_SLOT_INFO info, int characterId)
        {
            var item = DbContext.Items.FirstOrDefault(i => i.CharacterId == characterId && i.Index == uniqueId);

            if (item == null || item.Remaining == 0)
                return false;

            if (info.ItemUniqueId == 0)
            {
                var newItem = new Item
                {
                    ItemId = item.ItemId,
                    Quantity = item.Quantity,
                    AmmoCount = item.AmmoCount,
                    InvCount = item.InvCount,
                    CharacterId = characterId,
                    InventoryId = info.InventoryId,
                    SlotId = info.SlotId
                };

                DbContext.Items.Add(newItem);
                DbContext.SaveChanges();

                // Add attributes
                var attributes = DbContext.ItemAttributes.Where(a => a.ItemId == item.Id).ToList();
                foreach (var attribute in attributes)
                {
                    var attr = new ItemAttribute
                    {
                        ItemId = newItem.Id,
                        Primary = attribute.Primary,
                        Property = attribute.Property,
                        Value = attribute.Value
                    };

                    DbContext.ItemAttributes.Add(attr);
                }
            }
            else
            {
                var existingItem = DbContext.Items.FirstOrDefault(i => i.Id == info.ItemUniqueId);
                if (existingItem != null)
                {
                    existingItem.Quantity += item.Quantity;
                }
            }

            item.Remaining -= 1;
            DbContext.SaveChanges();

            return true;
        }

        public static SS2C_MERCHANT_LIST_RES GetMerchantList(Context ctx, byte[] msg)
        {
            var characterId = SessionManager.Sessions[ctx.Transport].Character.Id;
            var merchants = DbContext.Merchants.Where(m => m.CharacterId == characterId).ToList();

            if (!merchants.Any())
            {
                CreateMerchants(characterId);
                merchants = DbContext.Merchants.Where(m => m.CharacterId == characterId).ToList();
            }

            var res = new SS2C_MERCHANT_LIST_RES();

            foreach (var merchant in merchants)
            {
                if (DateTime.UtcNow >= merchant.RefreshTime)
                {
                    DeleteItemsMerchant(merchant.Id);
                    merchant.RefreshTime = DateTime.UtcNow.AddMinutes(15);
                }

                res.MerchantList.Add(new SMERCHANT_INFO
                {
                    MerchantId = (int)merchant.Merchant,
                    Faction = 0,
                    RemainTime = (int)(merchant.RefreshTime - DateTime.UtcNow).TotalSeconds,
                    IsUnidentified = 0
                });
            }

            return res;
        }

        public static SS2C_MERCHANT_STOCK_BUY_ITEM_LIST_RES GetBuyList(Context ctx, byte[] msg)
        {
            var req = SC2S_MERCHANT_STOCK_BUY_ITEM_LIST_REQ.Parser.ParseFrom(msg);
            var charId = SessionManager.Sessions[ctx.Transport].Character.Id;
            var merchant = DbContext.Merchants.FirstOrDefault(m => m.CharacterId == charId && m.Merchant == (MerchantClass)req.MerchantId);
            var items = DbContext.Items.Where(i => i.MerchantId == merchant.Id).ToList();

            if (!items.Any())
            {
                GenerateItemsMerchant(merchant.Merchant, merchant.Id, charId);
                items = DbContext.Items.Where(i => i.MerchantId == merchant.Id).ToList();
            }

            var res = new SS2C_MERCHANT_STOCK_BUY_ITEM_LIST_RES
            {
                Result = PacketCommand.SUCCESS,
                LoopMessageFlag = Define_Message.LoopFlag.PROGRESS
            };

            foreach (var item in items)
            {
                if (item.Remaining == 0)
                    continue;

                var attributes = DbContext.ItemAttributes.Where(a => a.ItemId == item.Id).ToList();
                var itemInfo = CharacterHandler.ItemToProtoItem(item, attributes, false);

                res.StockList.Add(new SMERCHANT_STOCK_BUY_ITEM_INFO
                {
                    StockBuyId = GetStockBuyId(merchant.Merchant, item.Index),
                    StockUniqueId = GetStockUniqueId(merchant.Merchant, item.Index),
                    ItemInfo = itemInfo
                });
            }

            ctx.Reply(res);
            return new SS2C_MERCHANT_STOCK_BUY_ITEM_LIST_RES
            {
                Result = PacketCommand.SUCCESS,
                LoopMessageFlag = Define_Message.LoopFlag.END,
                StockList = { }
            };
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES BuyItem(Context ctx, byte[] msg)
        {
            var req = SC2S_MERCHANT_STOCK_BUY_REQ.Parser.ParseFrom(msg);
            var charId = SessionManager.Sessions[ctx.Transport].Character.Id;

            foreach (var item in req.Items)
            {
                if (!AddToInventoryMerchant(item.UniqueId, item.Info, charId))
                {
                    return new SS2C_LOBBY_CHARACTER_INFO_RES
                    {
                        Result = PacketCommand.ERROR,
                        ErrorMessage = "Failed to add item to inventory."
                    };
                }
            }

            return new SS2C_LOBBY_CHARACTER_INFO_RES
            {
                Result = PacketCommand.SUCCESS,
                ErrorMessage = string.Empty
            };
        }
    }
}
