using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ChatLog
{
    [Key]
    public int Id { get; set; }

    public string Message { get; set; }

    public int AccountId { get; set; }

    public int ChatType { get; set; }

    public int ChatIndex { get; set; }

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

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
