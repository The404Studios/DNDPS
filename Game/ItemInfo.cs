using DC.Packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemInfo
{
    public int UniqueId { get; set; }
    public string ItemId { get; set; }
    public int ItemCount { get; set; }
    public int InventoryId { get; set; }
    public int SlotId { get; set; }
    public List<Tuple<string, int>> PrimaryProperties { get; set; }
    public List<Tuple<string, int>> SecondaryProperties { get; set; }

    public ItemInfo(
        int uniqueId,
        string itemId,
        int itemCount,
        int inventoryId,
        int slotId,
        List<Tuple<string, int>> primaryProperties,
        List<Tuple<string, int>> secondaryProperties)
    {
        UniqueId = uniqueId;
        ItemId = itemId;
        ItemCount = itemCount;
        InventoryId = inventoryId;
        SlotId = slotId;
        PrimaryProperties = primaryProperties;
        SecondaryProperties = secondaryProperties;
    }

    public SItem Create()
    {
        var newItem = new SItem
        {
            ItemUniqueId = UniqueId,
            ItemId = ItemId,
            ItemCount = ItemCount,
            InventoryId = InventoryId,
            SlotId = SlotId
        };

        foreach (var prop in PrimaryProperties)
        {
            var newProp = new SItemProperty
            {
                PropertyTypeId = prop.Item1,
                PropertyValue = prop.Item2
            };
            newItem.PrimaryPropertyArray.Add(newProp);
        }

        foreach (var prop in SecondaryProperties)
        {
            var newProp = new SItemProperty
            {
                PropertyTypeId = prop.Item1,
                PropertyValue = prop.Item2
            };
            newItem.SecondaryPropertyArray.Add(newProp);
        }

        return newItem;
    }
}
