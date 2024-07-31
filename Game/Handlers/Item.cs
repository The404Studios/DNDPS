using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SVERA.Services
{
    public static class ItemService
    {
        private static readonly Dictionary<string, Dictionary<string, dynamic>> jsonData = new();

        static ItemService()
        {
            LoadJsonData();
        }

        private static void LoadJsonData()
        {
            var currentDir = Path.GetDirectoryName(Path.GetFullPath(typeof(ItemService).Assembly.Location));

            foreach (ItemType itemType in Enum.GetValues(typeof(ItemType)))
            {
                var typeValue = itemType.ToString();
                var path = Path.Combine(currentDir, "..", "data", "items", typeValue);
                var finalPath = Path.GetFullPath(path);

                if (Directory.Exists(finalPath))
                {
                    var files = Directory.GetFiles(finalPath, "*.json");
                    if (files.Length > 0)
                    {
                        jsonData[typeValue] = new Dictionary<string, dynamic>();
                        foreach (var fileName in files)
                        {
                            var fileContent = File.ReadAllText(fileName);
                            var data = JsonConvert.DeserializeObject<dynamic>(fileContent);
                            jsonData[typeValue][Path.GetFileName(fileName)] = data;
                        }
                    }
                }
            }
        }

        public static Dictionary<string, dynamic> GetContent(string name, ItemType type, Rarity rarity)
        {
            var content = new Dictionary<string, dynamic>();
            var typeValue = type.ToString();
            var fileNameNoRarity = $"{name}.json";

            if (rarity == Rarity.NONE)
            {
                if (jsonData.TryGetValue(typeValue, out var typeData) && typeData.ContainsKey(fileNameNoRarity))
                {
                    content = typeData[fileNameNoRarity][0];
                }
            }
            else if (type != ItemType.WEAPONS && type != ItemType.ARMORS)
            {
                var dynamicFileName = $"{name}_{rarity}001.json";
                if (jsonData.TryGetValue(typeValue, out var typeData) && typeData.ContainsKey(dynamicFileName))
                {
                    content = typeData[dynamicFileName][0];
                }
            }
            else
            {
                if (jsonData.TryGetValue(typeValue, out var typeData) && typeData.ContainsKey(fileNameNoRarity))
                {
                    content = typeData[fileNameNoRarity];
                }
            }

            return content;
        }

        public static Dictionary<string, dynamic> GetContentBasedOn(Material material, ItemType itemType)
        {
            var obj = new Dictionary<string, dynamic>();
            var typeValue = itemType.ToString();
            var materialValue = material.ToString();

            if (jsonData.TryGetValue(typeValue, out var typeData))
            {
                foreach (var kvp in typeData)
                {
                    var value = kvp.Value;
                    if (itemType != ItemType.WEAPONS && value.material == materialValue)
                    {
                        obj[kvp.Key] = value;
                    }
                    else if (itemType == ItemType.WEAPONS)
                    {
                        obj[kvp.Key] = value;
                    }
                }
            }

            return obj;
        }

        public static Dictionary<string, dynamic> RandomGear(Dictionary<string, dynamic> content, int howMany)
        {
            var newResult = new Dictionary<string, dynamic>();
            var contentList = content.ToList();

            if (contentList.Count > 0)
            {
                while (newResult.Count < howMany)
                {
                    var randomItem = contentList[Random.Shared.Next(contentList.Count)];
                    if (!newResult.ContainsKey(randomItem.Key))
                    {
                        newResult[randomItem.Key] = randomItem.Value;
                    }
                }
            }

            return newResult;
        }

        public static List<Dictionary<string, dynamic>> RandomItemList(ItemType type, Material material, int itemCount)
        {
            var finalData = new List<Dictionary<string, dynamic>>();

            if (type != null && material != null && itemCount > 0)
            {
                var allGearWith = GetContentBasedOn(material, type);
                var inputList = RandomGear(allGearWith, itemCount);

                foreach (var item in inputList)
                {
                    var name = item.Value.name;
                    var allStats = item.Value.stats;
                    var allRarity = allStats.Keys.ToList();
                    if (allRarity.Count == 0)
                    {
                        continue;
                    }

                    var randomNumber = RandomRarity(allRarity);
                    finalData.Add(FormatData(item.Value, name, randomNumber, type));
                }
            }

            return finalData;
        }

        private static Rarity RandomRarity(List<Rarity> listOfRarity)
        {
            var listOfRarityList = listOfRarity.ToList();
            var length = listOfRarityList.Count;

            if (length == 0)
            {
                return Rarity.NONE;
            }
            if (length == 1)
            {
                return listOfRarityList[0];
            }

            var listOfChance = new[] { 45, 35, 24.5, 15.5, 8 };
            var rarityList = listOfRarityList.Skip(1).Take(4).ToList();
            return rarityList[Random.Shared.Choice(listOfChance, 1)[0]];
        }

        public static Dictionary<string, dynamic> GenerateNewItem(string name, ItemType type, Rarity rarity, int itemCount = 1)
        {
            var finalData = new Dictionary<string, dynamic>();
            var rarityStr = rarity.ToString();

            if (!string.IsNullOrEmpty(name) && type != null)
            {
                var data = GetContent(name, type, rarity);
                if (data != null)
                {
                    if (type != ItemType.WEAPONS && type != ItemType.ARMORS)
                    {
                        finalData = FormatOtherData(data, name, rarityStr, itemCount);
                    }
                    else
                    {
                        finalData = FormatData(data, name, rarityStr, type);
                    }
                }
            }

            return finalData;
        }

        private static Dictionary<string, dynamic> FormatOtherData(Dictionary<string, dynamic> data, string name, Rarity rarity, int itemCount)
        {
            var itemId = rarity == Rarity.NONE
                ? $"DesignDataItem:Id_Item_{name}"
                : $"DesignDataItem:Id_Item_{name}_{rarity}001";

            var finalData = new Dictionary<string, dynamic> { { "itemId", itemId } };
            var maxCount = Convert.ToInt32(data["Properties"]["Item"]["MaxCount"]);
            finalData["itemCount"] = itemCount <= maxCount ? itemCount : maxCount;

            return finalData;
        }

        private static List<Dictionary<string, dynamic>> ParsePropertiesToArray(Dictionary<string, dynamic> data, string rarity)
        {
            var properties = data["stats"][rarity];
            var propertiesArray = new List<Dictionary<string, dynamic>>();

            foreach (var kvp in properties)
            {
                var updatedKey = $"DesignDataItemPropertyType:{kvp.Key}";
                propertiesArray.Add(new Dictionary<string, dynamic>
                {
                    { "propertyTypeId", updatedKey },
                    { "propertyValue", kvp.Value }
                });
            }

            return propertiesArray;
        }

        private static List<Dictionary<string, dynamic>> ParseSecondaryPropertiesToArray(string rarity, ItemType itemType, string name)
        {
            var rarityInt = int.Parse(rarity);
            if (rarityInt == (int)Rarity.UNCOMMON || rarityInt == (int)Rarity.RARE ||
            rarityInt == (int)Rarity.EPIC || rarityInt == (int)Rarity.LEGENDARY ||
                rarityInt == (int)Rarity.UNIQUE)
            {
                return EffectsBasedOn(rarityInt, itemType, name);
            }

            return new List<Dictionary<string, dynamic>>();
        }

        private static List<Dictionary<string, dynamic>> EffectsBasedOn(int rarity, ItemType itemType, string name)
        {
            var propertiesArray = new List<Dictionary<string, dynamic>>();
            var randomEnhancements = new List<string>();
            var number = Random.Shared.Choice(new[] { rarity - 3, rarity - 2 }, new[] { 5, 95 });

            if (number == 0)
            {
                return propertiesArray;
            }

            if (itemType == ItemType.WEAPONS)
            {
                var weaponEnhancements = name.Contains("Magic") ? Enum.GetValues(typeof(EnhancementMagicWeapon)).Cast<EnhancementMagicWeapon>().ToList() : Enum.GetValues(typeof(EnhancementPhysicalWeapon)).Cast<EnhancementPhysicalWeapon>().ToList();
                randomEnhancements = weaponEnhancements.Take(number).Select(e => e.ToString()).ToList();
            }
            else if (itemType == ItemType.ARMORS)
            {
                var armorEnhancements = Enum.GetValues(typeof(EnhancementArmor)).Cast<EnhancementArmor>().ToList();
                randomEnhancements = armorEnhancements.Take(number).Select(e => e.ToString()).ToList();
            }

            if (randomEnhancements.Count == 0)
            {
                return propertiesArray;
            }

            foreach (var enha in randomEnhancements)
            {
                var randomValue = enha.Contains("._") ? Random.Shared.Next(9, 50) : Random.Shared.Next(1, 4);
                var updatedKey = $"DesignDataItemPropertyType:Id_ItemPropertyType_{enha}";
                propertiesArray.Add(new Dictionary<string, dynamic>
                {
                    { "propertyTypeId", updatedKey },
                    { "propertyValue", randomValue }
                });
            }

            return propertiesArray;
        }

        private static List<Dictionary<string, dynamic>> AdjustStatsBasedOnRanges(List<Dictionary<string, dynamic>> propertyArray)
        {
            var newPropertyArray = new List<Dictionary<string, dynamic>>();

            foreach (var obj in propertyArray)
            {
                var valuesArray = obj["propertyValue"] as List<dynamic>;

                var randomValue = 1;

                if (valuesArray != null && valuesArray.Count > 1)
                {
                    if (valuesArray[0] is int)
                    {
                        randomValue = Random.Shared.Next((int)valuesArray[0], (int)valuesArray[1]);
                    }
                    else if (valuesArray[0] is string && ((string)valuesArray[0]).Contains("%"))
                    {
                        var lowerBound = float.Parse(((string)valuesArray[0]).Trim('%'));
                        var upperBound = float.Parse(((string)valuesArray[1]).Trim('%'));
                        randomValue = (int)Random.Shared.NextDouble() * (upperBound - lowerBound) + lowerBound;
                        randomValue = $"{randomValue}%";
                    }
                }

                obj["propertyValue"] = randomValue;
                newPropertyArray.Add(obj);
            }

            return newPropertyArray;
        }

        private static Dictionary<string, dynamic> FormatData(Dictionary<string, dynamic> data, string name, string rarity, ItemType itemType)
        {
            var itemId = rarity == Rarity.NONE.ToString()
                ? $"DesignDataItem:Id_Item_{name}"
                : $"DesignDataItem:Id_Item_{name}_{rarity}001";

            var primaryPropertyArray = AdjustStatsBasedOnRanges(ParsePropertiesToArray(data, rarity));
            var secondaryPropertyArray = ParseSecondaryPropertiesToArray(rarity, itemType, name);

            return new Dictionary<string, dynamic>
            {
                { "itemId", itemId },
                { "primaryPropertyArray", primaryPropertyArray },
                { "secondaryPropertyArray", secondaryPropertyArray }
            };
        }
    }
}
