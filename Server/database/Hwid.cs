using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Hwid
{
    [Key]
    public int Id { get; set; }

    public int AccountId { get; set; }

    [StringLength(64)]
    public string Hwid { get; set; }

    public bool IsBanned { get; set; }

    public DateTime SeenAt { get; set; } = DateTime.UtcNow;

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
