using DC.Packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static SItem GenerateItem(
    ItemEnum name,
    ItemType type,
    Rarity rarity,
    Define_Item.InventoryId inventoryId,
    Define_Equipment.SlotId slotId,
    int itemCount = 1)
{
    var itemValues = ItemHandler.GenerateNewItem(name, type, rarity, itemCount);
    return ItemParser(itemValues, inventoryId, slotId, itemCount);
}
