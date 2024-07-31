using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Merchant
{
    [Key]
    public int Id { get; set; }

    public int CharacterId { get; set; }

    public MerchantClass MerchantClass { get; set; }

    public DateTime RefreshTime { get; set; } = DateTime.UtcNow;

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
