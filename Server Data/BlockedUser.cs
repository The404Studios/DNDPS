using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

public class BlockedUser
{
    [Key]
    public int Id { get; set; }

    public int BlockedBy { get; set; } // Character ID

    public int AccountId { get; set; }

    public int CharacterId { get; set; }

    [StringLength(20)]
    public string Nickname { get; set; }

    public Gender Gender { get; set; }

    public CharacterClass CharacterClass { get; set; }

    public DateTime BlockedAt { get; set; } = DateTime.UtcNow;

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
