using DC.Packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static SItem ItemParser(
    Dictionary<string, object> itemValues,
    Define_Item.InventoryId inventoryId,
    Define_Equipment.SlotId slotId,
    int itemCount)
{
    var newItem = new SItem
    {
        InventoryId = inventoryId,
        SlotId = slotId,
        ItemId = (string)itemValues["itemId"],
        ItemCount = Convert.ToInt32(itemValues.GetValueOrDefault("itemCount", itemCount))
    };

    var primaryProperties = itemValues.GetValueOrDefault("primaryPropertyArray", new List<Dictionary<string, object>>()) as List<Dictionary<string, object>>;
    if (primaryProperties != null && primaryProperties.Count >= 1)
    {
        foreach (var property in primaryProperties)
        {
            var itemProperty = new SItemProperty
            {
                PropertyTypeId = (string)property["propertyTypeId"]
            };

            if (property["propertyValue"] is string strValue)
            {
                itemProperty.PropertyValue = int.Parse(strValue.Substring(0, strValue.Length - 3)) * 10;
            }
            else
            {
                itemProperty.PropertyValue = Convert.ToInt32(property["propertyValue"]);
            }

            newItem.PrimaryPropertyArray.Add(itemProperty);
        }
    }

    var secondaryProperties = itemValues.GetValueOrDefault("secondaryPropertyArray", new List<Dictionary<string, object>>()) as List<Dictionary<string, object>>;
    if (secondaryProperties != null && secondaryProperties.Count >= 1)
    {
        foreach (var property in secondaryProperties)
        {
            var itemProperty = new SItemProperty
            {
                PropertyTypeId = (string)property["propertyTypeId"],
                PropertyValue = Convert.ToInt32(property["propertyValue"])
            };

            newItem.SecondaryPropertyArray.Add(itemProperty);
        }
    }

    return newItem;
}

