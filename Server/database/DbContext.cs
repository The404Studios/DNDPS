using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Spell> Spells { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemAttribute> ItemAttributes { get; set; }
    public DbSet<Merchant> Merchants { get; set; }
    public DbSet<Hwid> Hwids { get; set; }
    public DbSet<BlockedUser> BlockedUsers { get; set; }
    public DbSet<ChatLog> ChatLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }
}
