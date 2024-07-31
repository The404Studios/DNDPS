using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

public class Character
{
    [Key]
    public int Id { get; set; }

    public int AccountId { get; set; }

    [StringLength(20)]
    public string Nickname { get; set; }

    public Gender Gender { get; set; }
    public CharacterClass CharacterClass { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int Level { get; set; } = Config.GameSettings.StartingLevel;

    public int Experience { get; set; } = 0;

    public int KarmaRating { get; set; } = 0;

    [StringLength(15)]
    public string StreamingNickname { get; set; }

    public string Perk0 { get; set; } = "";
    public string Perk1 { get; set; } = "";
    public string Perk2 { get; set; } = "";
    public string Perk3 { get; set; } = "";

    public string Skill0 { get; set; } = "";
    public string Skill1 { get; set; } = "";

    public int RankingCoin { get; set; } = 0;
    public int RankingKill { get; set; } = 0;
    public int RankingEscape { get; set; } = 0;
    public int RankingAdventure { get; set; } = 0;
    public int RankingLich { get; set; } = 0;
    public int RankingGhostking { get; set; } = 0;

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
