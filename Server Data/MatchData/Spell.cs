using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Spell
{
    [Key]
    public int Id { get; set; }

    public int CharacterId { get; set; }

    public string SpellId { get; set; } = "";

    public int SlotId { get; set; }

    public int SequenceId { get; set; }

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
