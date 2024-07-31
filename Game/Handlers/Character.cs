using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using DarkAndDarker.Cryptography.Sequence.Account;
using DarkAndDarker.Cryptography.Sequence.CharacterClass;
using DarkAndDarker.Cryptography.Sequence.Customize;
using DC.Packet;

namespace YourNamespace
{
    public class CharacterService
    {
        private static Random random = new Random();

        public static pItem.SItem ItemToProtoItem(Item item, List<ItemAttribute> attributes, bool forCharacter = true)
        {
            var ret = new pItem.SItem
            {
                itemUniqueId = item.Id,
                itemId = item.ItemId,
                itemCount = item.Quantity,
                itemAmmoCount = item.AmmoCount,
                itemContentsCount = item.InvCount
            };

            if (forCharacter)
            {
                ret.inventoryId = item.InventoryId;
                ret.slotId = item.SlotId;
            }

            foreach (var attribute in attributes)
            {
                var property = new pItem.SItemProperty
                {
                    propertyTypeId = attribute.Property,
                    propertyValue = attribute.Value
                };

                if (attribute.Primary)
                {
                    ret.primaryPropertyArray.Add(property);
                }
                else
                {
                    ret.secondaryPropertyArray.Add(property);
                }
            }

            return ret;
        }

        public static SS2C_ACCOUNT_CHARACTER_LIST_RES ListCharacters(Context ctx, byte[] msg)
        {
            var req = SC2S_ACCOUNT_CHARACTER_LIST_REQ.Parser.ParseFrom(msg);
            var query = db.Query<Character>().Where(c => c.AccountId == sessions[ctx.Transport].Account.Id).ToList();

            var res = new SS2C_ACCOUNT_CHARACTER_LIST_RES
            {
                totalCharacterCount = query.Count,
                pageIndex = req.pageIndex
            };

            int start = (res.pageIndex - 1) * 7;
            int end = start + 7;

            foreach (var result in query.Skip(start).Take(7))
            {
                var info = new SLOGIN_CHARACTER_INFO
                {
                    characterId = result.Id.ToString(),
                    nickName = new SACCOUNT_NICKNAME
                    {
                        originalNickName = result.Nickname,
                        streamingModeNickName = result.StreamingNickname
                    },
                    level = result.Level,
                    characterClass = CharacterClassConverter.ToValue(result.CharacterClass),
                    gender = GenderConverter.ToValue(result.Gender),
                    createAt = result.CreatedAt.ToTimestamp()
                };

                foreach (var (item, attributes) in Inventory.GetAllItems(result.Id, Define_Item.InventoryId.EQUIPMENT))
                {
                    info.equipItemList.Add(ItemToProtoItem(item, attributes));
                }

                res.characterList.Add(info);
            }

            return res;
        }

        public static SS2C_ACCOUNT_CHARACTER_CREATE_RES CreateCharacter(Context ctx, byte[] msg)
        {
            var req = SC2S_ACCOUNT_CHARACTER_CREATE_REQ.Parser.ParseFrom(msg);
            var res = new SS2C_ACCOUNT_CHARACTER_CREATE_RES { result = PacketCommand.SUCCESS };

            if (req.nickName.Length < Define_Character.MIN)
            {
                res.result = PacketCommand.FAIL_CHARACTER_NICKNAME_LENGTH_SHORTAGE;
                return res;
            }

            if (req.nickName.Length > Define_Character.MAX)
            {
                res.result = PacketCommand.FAIL_CHARACTER_NICKNAME_LENGTH_OVER;
                return res;
            }

            if (db.Query<Character>().Any(c => c.Nickname.Equals(req.nickName, StringComparison.OrdinalIgnoreCase)))
            {
                res.result = PacketCommand.FAIL_DUPLICATE_NICKNAME;
                return res;
            }

            var charClass = CharacterClassConverter.FromValue(req.characterClass);
            var char = new Character
            {
                AccountId = sessions[ctx.Transport].Account.Id,
                Nickname = req.nickName,
                StreamingNickname = $"Fighter#{random.Next(1000000, 1700000)}",
                Gender = GenderConverter.FromValue(req.gender),
                CharacterClass = charClass
            };

            char.Perk0 = Perks[charClass][0];
            char.Skill0 = Skills[charClass][0];
            char.Skill1 = Skills[charClass][1];
            char.Save();

            var starterItems = CreateItemsPerClass(charClass);

            foreach (var item in starterItems)
            {
                var it = new Item
                {
                    CharacterId = char.Id,
                    ItemId = item.itemId,
                    Quantity = item.itemCount,
                    InventoryId = item.inventoryId,
                    SlotId = item.slotId
                };

                it.Save();

                foreach (var attribute in item.primaryPropertyArray)
                {
                    var attr = new ItemAttribute
                    {
                        ItemId = it.Id,
                        Primary = true,
                        Property = attribute.propertyTypeId,
                        Value = attribute.propertyValue
                    };

                    attr.Save();
                }

                foreach (var attribute in item.secondaryPropertyArray)
                {
                    var attr = new ItemAttribute
                    {
                        ItemId = it.Id,
                        Primary = false,
                        Property = attribute.propertyTypeId,
                        Value = attribute.propertyValue
                    };

                    attr.Save();
                }
            }

            return res;
        }

        public static SS2C_ACCOUNT_CHARACTER_DELETE_RES DeleteCharacter(Context ctx, byte[] msg)
        {
            var req = SC2S_ACCOUNT_CHARACTER_DELETE_REQ.Parser.ParseFrom(msg);
            var query = db.Query<Character>().FirstOrDefault(c => c.Id == req.characterId);
            var res = new SS2C_ACCOUNT_CHARACTER_DELETE_RES { result = PacketCommand.SUCCESS };

            if (query.AccountId != sessions[ctx.Transport].Account.Id)
            {
                res.result = PacketCommand.FAIL_GENERAL;
                return res;
            }

            Merchant.DeleteMerchants(query.Id);

            var items = db.Query<Item>().Where(i => i.CharacterId == req.characterId).ToList();
            foreach (var item in items)
            {
                var attributes = db.Query<ItemAttribute>().Where(a => a.ItemId == item.Id).ToList();

                foreach (var attribute in attributes)
                {
                    attribute.Delete();
                }

                item.Delete();
            }

            var spells = db.Query<Spell>().Where(s => s.CharacterId == req.characterId).ToList();
            foreach (var spell in spells)
            {
                spell.Delete();
            }

            query.Delete();
            return res;
        }

        public static SS2C_CUSTOMIZE_CHARACTER_INFO_RES CustomiseCharacterInfo(Context ctx, byte[] msg)
        {
            var custom = new SCUSTOMIZE_CHARACTER
            {
                customizeCharacterId = "1",
                isEquip = 1,
                isNew = 1
            };

            var res = new SS2C_CUSTOMIZE_CHARACTER_INFO_RES
            {
                loopFlag = 0
            };

            res.customizeCharacters.Add(custom);
            return res;
        }

        public static SS2C_LOBBY_CHARACTER_INFO_RES CharacterInfo(Context ctx, byte[] msg)
        {
            var character = sessions[ctx.Transport].Character;

            var charInfo = new SCHARACTER_INFO
            {
                accountId = sessions[ctx.Transport].Account.Id.ToString(),
                nickName = new SACCOUNT_NICKNAME
                {
                    originalNickName = character.Nickname,
                    streamingModeNickName = character.StreamingNickname
                },
                characterClass = CharacterClassConverter.ToValue(character.CharacterClass),
                characterId = character.Id.ToString(),
                gender = GenderConverter.ToValue(character.Gender),
                level = character.Level
            };

            foreach (var (item, attributes) in Inventory.GetAllItems(character.Id))
            {
                if (item.InventoryId >= Define_Item.InventoryId.STORAGE)
                {
                    charInfo.CharacterStorageItemList.Add(ItemToProtoItem(item, attributes));
                }
                else
                {
                    charInfo.CharacterItemList.Add(ItemToProtoItem(item, attributes));
                }
            }

            var res = new SS2C_LOBBY_CHARACTER_INFO_RES
            {
                result = PacketCommand.SUCCESS,
                characterDataBase = charInfo
            };

            return res;
        }

        public static SS2C_CLASS_LEVEL_INFO_RES GetExperience(Context ctx, byte[] msg)
        {
            var character = sessions[ctx.Transport].Character;
            var res = new SS2C_CLASS_LEVEL_INFO_RES
            {
                level = character.Level,
                exp = character.Experience,
                expBegin = 0,
                expLimit = 40 + (character.Level / 5 * 20)
            };

            return res;
        }

        public static SS2C_CLASS_PERK_LIST_RES ListPerks(Context ctx, byte[] msg)
        {
            var character = sessions[ctx.Transport].Character;
            var selectedPerks = new List<int> { character.Perk0, character.Perk1, character.Perk2, character.Perk3 };

            var res = new SS2C_CLASS_PERK_LIST_RES();
            var perks = Perks[character.CharacterClass];
            int index = 0;

            foreach (var perk in perks)
            {
                if (!selectedPerks.Contains(perk))
                {
                    res.perks.Add(new pItem.SPerk
                    {
                        index = index,
                        perkId = perk
                    });
                    index++;
                }
            }

            return res;
        }

        public static SS2C_CLASS_SKILL_LIST_RES ListSkills(Context ctx, byte[] msg)
        {
            var character = sessions[ctx.Transport].Character;
            var selectedSkills = new List<int> { character.Skill0, character.Skill1 };

            var res = new SS2C_CLASS_SKILL_LIST_RES();
            var skills = Skills[character.CharacterClass];
            int index = 0;

            foreach (var skill in skills)
            {
                if (!selectedSkills.Contains(skill))
                {
                    res.skills.Add(new pItem.SSkill
                    {
                        index = index,
                        skillId = skill
                    });
                    index++;
                }
            }

            return res;
        }

        public static SS2C_CLASS_UPGRADE_RES UpgradeCharacter(Context ctx, byte[] msg)
        {
            var req = SC2S_CLASS_UPGRADE_REQ.Parser.ParseFrom(msg);
            var character = sessions[ctx.Transport].Character;
            var res = new SS2C_CLASS_UPGRADE_RES { result = PacketCommand.SUCCESS };

            var levelRequired = req.level;
            if (levelRequired > character.Level)
            {
                res.result = PacketCommand.FAIL_GENERAL;
                return res;
            }

            if (req.level == 0)
            {
                res.result = PacketCommand.FAIL_GENERAL;
                return res;
            }

            var newSkills = Skills[character.CharacterClass].Skip(2).Take(2).ToList();
            foreach (var skill in newSkills)
            {
                if (skill == req.newSkill)
                {
                    res.result = PacketCommand.FAIL_GENERAL;
                    return res;
                }
            }

            character.Skill1 = req.newSkill;
            character.Save();
            return res;
        }

        private static List<ProtoItem> CreateItemsPerClass(CharacterClass charClass)
        {
            // Replace with your actual item creation logic based on character class
            // This is a stub function
            return new List<ProtoItem>();
        }
    }
}
