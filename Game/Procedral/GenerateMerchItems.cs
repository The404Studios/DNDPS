using DC.Packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static List<Tuple<SItem, int>> GenerateMerchItems(MerchantClass merchId)
{
    var items = Merchant.FixedItems[merchId];
    var ret = new List<Tuple<SItem, int>>();

    foreach (var itemMerch in items)
    {
        var newItem = new SItem
        {
            ItemId = itemMerch.Item1,
            ItemCount = itemMerch.Item2
        };

        ret.Add(new Tuple<SItem, int>(newItem, itemMerch.Item3));
    }

    var randomItems = GenerateRandomItem(merchId, Merchant.BuyMapping[merchId].Count - items.Count);
    ret.AddRange(randomItems);

    return ret;
}
