using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ItemAttribute
{
    [Key]
    public int Id { get; set; }

    public int ItemId { get; set; }

    public bool Primary { get; set; }

    public string Property { get; set; }

    public int Value { get; set; }

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
