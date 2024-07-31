using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Username { get; set; }

    public string Password { get; set; }

    [StringLength(21)]
    public string SecretToken { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int? BanType { get; set; }

    public void Save(DbContext dbContext)
    {
        dbContext.Add(this);
        dbContext.SaveChanges();
    }
}
