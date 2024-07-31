using DC.Packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static List<Tuple<SItem, int>> GenerateRandomItem(MerchantClass merchId, int amount)
{
    var ret = new List<Tuple<SItem, int>>();

    ItemType itemType;
    Material material;

    switch (merchId)
    {
        case MerchantClass.Armourer:
            itemType = ItemType.Armors;
            material = Material.Plate;
            break;
        case MerchantClass.Weaponsmith:
            itemType = ItemType.Weapons;
            material = Material.None;
            break;
        case MerchantClass.Surgeon:
        case MerchantClass.Woodsman:
        case MerchantClass.Alchemist:
            itemType = ItemType.Utility;
            material = Material.None;
            break;
        case MerchantClass.Leathersmith:
            itemType = ItemType.Armors;
            material = Material.Leather;
            break;
        case MerchantClass.Tailor:
            itemType = ItemType.Armors;
            material = Material.Cloth;
            break;
        case MerchantClass.GoblinMerchant:
            itemType = ItemType.Armors;
            material = Material.Leather;
            break;
        case MerchantClass.Santa:
        case MerchantClass.PumpkinMan:
            itemType = ItemType.Utility;
            material = Material.None;
            break;
        default:
            return ret;
    }

    var items = ItemHandler.RandomItemList(itemType, (int)material, amount);
    foreach (var item in items)
    {
        ret.Add(new Tuple<SItem, int>(ItemParser(item, 1, 1, 1), 1));
    }

    // Sort items per rarity
    var sortedRet = new List<Tuple<SItem, int>>(ret);
    sortedRet.Sort((x, y) =>
    {
        var xRarity = int.Parse(new string(x.Item1.ItemId.TakeLast(4).Where(char.IsDigit).ToArray()));
        var yRarity = int.Parse(new string(y.Item1.ItemId.TakeLast(4).Where(char.IsDigit).ToArray()));
        return xRarity.CompareTo(yRarity);
    });

    return sortedRet;
}
