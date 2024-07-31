using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Item
{
    [Key]
    public int Id { get; set; }

    public int CharacterId { get; set; }

    public string ItemId { get; set; }

    public int Quantity { get; set; }

    public int AmmoCount { get; set; } = 0;

    public int InvCount { get; set; } = 0;

    public int? SlotId { get; set; }

    public int? InventoryId { get; set; }

    public int MerchantId { get; set; } = 0;

    public int Remaining { get; set; } = 0;

    public int Index { get; set; } = 0;

    public void Save(DbContext dbContext)
    {
        dbContext.Add(this);
        dbContext.SaveChanges();
    }

    public void Delete(DbContext dbContext)
    {
        dbContext.Remove(this);
        dbContext.SaveChanges();
    }
}
