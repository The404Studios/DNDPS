using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


// threw this together in about 3 min tryna figure out where everything is at. these all should be a seperate class.

// merchant map
public static class MerchantData
{
    public static readonly Dictionary<MerchantClass, List<int>> Sellback = new Dictionary<MerchantClass, List<int>>()
    {
        { MerchantClass.WEAPONSMITH, new List<int> { 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 998, 999, 1000, 1001, 1002, 1003, 1004, 1005 } },
        { MerchantClass.ARMOURER, new List<int> { /* List of integers for ARMOURER */ } },
        { MerchantClass.SURGEON, new List<int> { 480, 481, 482, 483, 484, 485, 486, 487, 488, 489, 490 } },
        { MerchantClass.ALCHEMIST, new List<int> { 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502 } },
        { MerchantClass.WOODSMAN, new List<int> { 503, 504, 505, 506, 507, 508, 509, 510, 511, 512 } },
        { MerchantClass.TAVERNMASTER, new List<int> { /* List of integers for TAVERNMASTER */ } },
        // Add other merchant classes similarly
    };
}


// buy back
public static class MerchantData2
{
    public static readonly Dictionary<MerchantClass, List<(int, int)>> BuyMapping = new Dictionary<MerchantClass, List<(int, int)>>()
    {
        { MerchantClass.SURGEON, new List<(int, int)> { (229, 1), (230, 1), (231, 1), (232, 1) } },
        { MerchantClass.SANTA, new List<(int, int)> { (167, 4), (171, 3), (174, 4), (178, 3), (181, 2), (183, 4), (187, 4), (191, 3), (194, 4), (198, 5), (203, 4), (207, 4), (211, 4), (215, 3), (218, 4), (222, 4), (226, 3) } },
        { MerchantClass.WOODSMAN, new List<(int, int)> { (447, 1), (448, 1), (449, 3), (452, 1), (453, 1), (454, 2), (456, 4), (460, 12), (472, 12), (484, 1), (485, 1) } },
        { MerchantClass.TAILOR, new List<(int, int)> { (233, 1), (234, 1), (235, 1), (236, 1), (237, 1), (238, 1), (239, 2), (241, 3), (244, 11), (255, 11) } },
        { MerchantClass.TREASURER, new List<(int, int)> { (269, 1), (270, 1), (271, 1), (272, 1) } },
        { MerchantClass.LEATHERSMITH, new List<(int, int)> { (58, 1), (59, 1), (60, 1), (61, 1), (62, 1), (63, 2), (65, 8), (73, 15), (88, 15) } },
        { MerchantClass.ARMOURER, new List<(int, int)> { (18, 1), (19, 1), (20, 1), (21, 1), (22, 4), (26, 2), (28, 2), (30, 4), (34, 12), (46, 12) } },
        { MerchantClass.THECOLLECTOR, new List<(int, int)> { } },
        { MerchantClass.ALCHEMIST, new List<(int, int)> { (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 3), (10, 4), (14, 4) } },
        { MerchantClass.TAVERNMASTER, new List<(int, int)> { (266, 1), (267, 1), (268, 1) } },
        { MerchantClass.WEAPONSMITH, new List<(int, int)> { (342, 1), (343, 2), (345, 2), (347, 1), (348, 1), (349, 5), (354, 3), (357, 4), (361, 7), (368, 7), (375, 9), (384, 9), (393, 16), (409, 19), (428, 32), (444, 3) } },
        { MerchantClass.GOBLINMERCHANT, new List<(int, int)> { (486, 216) } },
        { MerchantClass.VALENTINE, new List<(int, int)> { (273, 4), (277, 3), (280, 8), (288, 5), (293, 4), (297, 4), (301, 5), (306, 5), (311, 5), (316, 4), (320, 4), (324, 4), (328, 3), (331, 4), (335, 4), (339, 3) } },
        { MerchantClass.PUMPKINMAN, new List<(int, int)> { (104, 4), (108, 3), (111, 4), (115, 5), (120, 4), (124, 4), (128, 3), (131, 4), (135, 5), (140, 4), (144, 4), (148, 4), (152, 3), (155, 4), (159, 4), (163, 2) } },
    };
}

// sell back
public static class MerchantData3
{
    public static readonly Dictionary<MerchantClass, List<(string, int, int)>> FixedItems = new Dictionary<MerchantClass, List<(string, int, int)>>()
    {
        { MerchantClass.SURGEON, new List<(string, int, int)> { ("DesignDataItem:Id_Item_Bandage_0001", 1, 3), ("DesignDataItem:Id_Item_Bandage_2001", 1, 3), ("DesignDataItem:Id_Item_Bandage_1001", 3, 3), ("DesignDataItem:Id_Item_Bandage_2001", 3, 3) } },
        { MerchantClass.SANTA, new List<(string, int, int)> { ("DesignDataItem:Id_Item_CandyCane", 1, 50), ("DesignDataItem:Id_Item_CandyCorns", 1, 50) } },
        { MerchantClass.WOODSMAN, new List<(string, int, int)> { ("DesignDataItem:Id_Item_Arrow_0001", 15, 50), ("DesignDataItem:Id_Item_Bolt_0001", 15, 50), ("DesignDataItem:Id_Item_FranciscaAxe_1001", 3, 3), ("DesignDataItem:Id_Item_CampfireKit_1001", 1, 3), ("DesignDataItem:Id_Item_ThrowingKnife_1001", 10, 50), ("DesignDataItem:Id_Item_ThrowingAxe_1001", 1, 5) } },
        { MerchantClass.TAILOR, new List<(string, int, int)> { ("DesignDataItem:Id_Item_CloakOfInvisibility_0001", 1, 1), ("DesignDataItem:Id_Item_StitchedBoots_1001", 1, 1), ("DesignDataItem:Id_Item_StitchedShirt_1001", 1, 1), ("DesignDataItem:Id_Item_StitchedHood_1001", 1, 1) } },
        { MerchantClass.TREASURER, new List<(string, int, int)> { ("DesignDataItem:Id_Item_GoldCoin_0001", 1, 100) } },
        { MerchantClass.LEATHERSMITH, new List<(string, int, int)> { ("DesignDataItem:Id_Item_LeatherGloves_0001", 1, 1), ("DesignDataItem:Id_Item_LeatherBoots_0001", 1, 1) } },
        { MerchantClass.ARMOURER, new List<(string, int, int)> { ("DesignDataItem:Id_Item_Breastplate_0001", 1, 1), ("DesignDataItem:Id_Item_LegPlates_0001", 1, 1) } },
        { MerchantClass.THECOLLECTOR, new List<(string, int, int)> { } },
        { MerchantClass.ALCHEMIST, new List<(string, int, int)> { ("DesignDataItem:Id_Item_Potion_Health_1001", 1, 5), ("DesignDataItem:Id_Item_Potion_Mana_1001", 1, 5) } },
        { MerchantClass.TAVERNMASTER, new List<(string, int, int)> { ("DesignDataItem:Id_Item_BeerMug_0001", 1, 1), ("DesignDataItem:Id_Item_Snacks_0001", 1, 5) } },
        { MerchantClass.WEAPONSMITH, new List<(string, int, int)> { ("DesignDataItem:Id_Item_Sword_0001", 1, 1), ("DesignDataItem:Id_Item_Shield_0001", 1, 1) } },
        { MerchantClass.GOBLINMERCHANT, new List<(string, int, int)> { ("DesignDataItem:Id_Item_GoblinTrinket_0001", 1, 1) } },
        { MerchantClass.VALENTINE, new List<(string, int, int)> { ("DesignDataItem:Id_Item_HeartCharm_0001", 1, 1) } },
        { MerchantClass.PUMPKINMAN, new List<(string, int, int)> { ("DesignDataItem:Id_Item_PumpkinHat_0001", 1, 1) } }
    };
}


public enum CharacterClass1
{
    BARBARIAN,
    BARD,
    CLERIC,
    FIGHTER,
    RANGER,
    ROGUE,
    WIZARD
}

public static class PerkData
{
    public static readonly Dictionary<CharacterClass, List<string>> Perks = new Dictionary<CharacterClass, List<string>>()
    {
        { CharacterClass.BARBARIAN, new List<string>
            {
                "DesignDataPerk:Id_Perk_AxeSpecialization",
                "DesignDataPerk:Id_Perk_Berserker",
                "DesignDataPerk:Id_Perk_Carnage",
                "DesignDataPerk:Id_Perk_IronWill",
                "DesignDataPerk:Id_Perk_MoraleBoost",
                "DesignDataPerk:Id_Perk_Savage",
                "DesignDataPerk:Id_Perk_Crush",
                "DesignDataPerk:Id_Perk_Robust",
                "DesignDataPerk:Id_Perk_TwoHander",
                "DesignDataPerk:Id_Perk_PotionChugger",
                "DesignDataPerk:Id_Perk_Executioner"
            }
        },
        { CharacterClass.BARD, new List<string>
            {
                "DesignDataPerk:Id_Perk_LoreMastery",
                "DesignDataPerk:Id_Perk_MelodicProtection",
                "DesignDataPerk:Id_Perk_RapierMastery",
                "DesignDataPerk:Id_Perk_WanderersLuck",
                "DesignDataPerk:Id_Perk_WarSong"
            }
        },
        { CharacterClass.CLERIC, new List<string>
            {
                "DesignDataPerk:Id_Perk_AdvancedHealer",
                "DesignDataPerk:Id_Perk_BluntWeaponMastery",
                "DesignDataPerk:Id_Perk_Brewmaster",
                "DesignDataPerk:Id_Perk_Kindness",
                "DesignDataPerk:Id_Perk_Perseverance",
                "DesignDataPerk:Id_Perk_ProtectionfromEvil",
                "DesignDataPerk:Id_Perk_Requiem",
                "DesignDataPerk:Id_Perk_UndeadSlaying",
                "DesignDataPerk:Id_Perk_HolyAura"
            }
        },
        { CharacterClass.FIGHTER, new List<string>
            {
                "DesignDataPerk:Id_Perk_Barricade",
                "DesignDataPerk:Id_Perk_ComboAttack",
                "DesignDataPerk:Id_Perk_Counterattack",
                "DesignDataPerk:Id_Perk_DefenseMastery",
                "DesignDataPerk:Id_Perk_DualWield",
                "DesignDataPerk:Id_Perk_ProjectileResistance",
                "DesignDataPerk:Id_Perk_ShieldMastery",
                "DesignDataPerk:Id_Perk_Swift",
                "DesignDataPerk:Id_Perk_WeaponMastery",
                "DesignDataPerk:Id_Perk_AdrenalineSpike",
                "DesignDataPerk:Id_Perk_Slayer"
            }
        },
        { CharacterClass.RANGER, new List<string>
            {
                "DesignDataPerk:Id_Perk_CrossbowMastery",
                "DesignDataPerk:Id_Perk_EnhancedHearing",
                "DesignDataPerk:Id_Perk_Kinesthesia",
                "DesignDataPerk:Id_Perk_NimbleHands",
                "DesignDataPerk:Id_Perk_RangedWeaponsMastery",
                "DesignDataPerk:Id_Perk_Sharpshooter",
                "DesignDataPerk:Id_Perk_SpearProficiency",
                "DesignDataPerk:Id_Perk_Chase",
                "DesignDataPerk:Id_Perk_TrapMastery",
                "DesignDataPerk:Id_Perk_CripplingShot",
                "DesignDataPerk:Id_Perk_QuickReload"
            }
        },
        { CharacterClass.ROGUE, new List<string>
            {
                "DesignDataPerk:Id_Perk_Ambush",
                "DesignDataPerk:Id_Perk_BackAttack",
                "DesignDataPerk:Id_Perk_Creep",
                "DesignDataPerk:Id_Perk_DaggerMastery",
                "DesignDataPerk:Id_Perk_HiddenPocket",
                "DesignDataPerk:Id_Perk_LockpickingMastery",
                "DesignDataPerk:Id_Perk_Pickpocket",
                "DesignDataPerk:Id_Perk_PoisonedWeapon",
                "DesignDataPerk:Id_Perk_Stealth",
                "DesignDataPerk:Id_Perk_TrapDetection",
                "DesignDataPerk:Id_Perk_DoubleJump",
                "DesignDataPerk:Id_Perk_Jokester",
                "DesignDataPerk:Id_Perk_ShadowRunner",
                "DesignDataPerk:Id_Perk_Thrust"
            }
        },
        { CharacterClass.WIZARD, new List<string>
            {
                "DesignDataPerk:Id_Perk_ArcaneFeedback",
                "DesignDataPerk:Id_Perk_ArcaneMastery",
                "DesignDataPerk:Id_Perk_FireMastery",
                "DesignDataPerk:Id_Perk_IceShield",
                "DesignDataPerk:Id_Perk_ManaSurge",
                "DesignDataPerk:Id_Perk_Melt",
                "DesignDataPerk:Id_Perk_QuickChant",
                "DesignDataPerk:Id_Perk_ReactiveShield",
                "DesignDataPerk:Id_Perk_Sage"
            }
        }
    };
}

public static class SkillData
{
    public static readonly Dictionary<CharacterClass, List<string>> Skills = new Dictionary<CharacterClass, List<string>>()
    {
        { CharacterClass.BARBARIAN, new List<string>
            {
                "DesignDataSkill:Id_Skill_Rage",
                "DesignDataSkill:Id_Skill_RecklessAttack",
                "DesignDataSkill:Id_Skill_SavageRoar",
                "DesignDataSkill:Id_Skill_WarCry",
                "DesignDataSkill:Id_Skill_AchillesStrike",
                "DesignDataSkill:Id_Skill_BloodExchange",
                "DesignDataSkill:Id_Skill_LifeSiphon"
            }
        },
        { CharacterClass.BARD, new List<string>
            {
                "DesignDataSkill:Id_Skill_Encore",
                "DesignDataSkill:Id_Skill_Dissonance",
                "DesignDataSkill:Id_Skill_MusicMemory1",
                "DesignDataSkill:Id_Skill_MusicMemory2"
            }
        },
        { CharacterClass.CLERIC, new List<string>
            {
                "DesignDataSkill:Id_Skill_HolyPurification",
                "DesignDataSkill:Id_Skill_Judgement",
                "DesignDataSkill:Id_Skill_Smite",
                "DesignDataSkill:Id_Skill_SpellMemory1",
                "DesignDataSkill:Id_Skill_SpellMemory2",
                "DesignDataSkill:Id_Skill_DivineProtection"
            }
        },
        { CharacterClass.FIGHTER, new List<string>
            {
                "DesignDataSkill:Id_Skill_AdrenalineRush",
                "DesignDataSkill:Id_Skill_Breakthrough",
                "DesignDataSkill:Id_Skill_SecondWind",
                "DesignDataSkill:Id_Skill_Sprint",
                "DesignDataSkill:Id_Skill_Taunt",
                "DesignDataSkill:Id_Skill_VictoryStrike",
                "DesignDataSkill:Id_Skill_PerfectBlock",
                "DesignDataSkill:Id_Skill_ShieldSlam"
            }
        },
        { CharacterClass.RANGER, new List<string>
            {
                "DesignDataSkill:Id_Skill_FieldRation",
                "DesignDataSkill:Id_Skill_MultiShot",
                "DesignDataSkill:Id_Skill_QuickFire",
                "DesignDataSkill:Id_Skill_QuickShot",
                "DesignDataSkill:Id_Skill_TrueShot",
                "DesignDataSkill:Id_Skill_ForcefulShot",
                "DesignDataSkill:Id_Skill_PenetratingShot"
            }
        },
        { CharacterClass.ROGUE, new List<string>
            {
                "DesignDataSkill:Id_Skill_Caltrop",
                "DesignDataSkill:Id_Skill_Hide",
                "DesignDataSkill:Id_Skill_Rupture",
                "DesignDataSkill:Id_Skill_SmokeBomb",
                "DesignDataSkill:Id_Skill_WeakpointAttack",
                "DesignDataSkill:Id_Skill_CutThroat",
                "DesignDataSkill:Id_Skill_Tumbling"
            }
        },
        { CharacterClass.WIZARD, new List<string>
            {
                "DesignDataSkill:Id_Skill_IntenseFocus",
                "DesignDataSkill:Id_Skill_Meditation",
                "DesignDataSkill:Id_Skill_SpellMemory1",
                "DesignDataSkill:Id_Skill_SpellMemory2",
                "DesignDataSkill:Id_Skill_Arcane"
        }
    }
}

namespace DarkAndDarker.Game.items
{
    internal class Manager
    {
    }
}

public static class LevelRequirements
{
    public static readonly List<int> Levels = new List<int> { 1, 5, 10, 15 };
}


public enum MerchantClass
{
    WEAPONSMITH,
    ARMOURER,
    SURGEON,
    ALCHEMIST,
    WOODSMAN,
    TAVERNMASTER,
    SANTA,
    TAILOR,
    TREASURER,
    LEATHERSMITH,
    THECOLLECTOR,
    GOBLINMERCHANT,
    VALENTINE,
    PUMPKINMAN
}

public static class SpellData
{
    public static readonly Dictionary<CharacterClass, List<string>> Spells = new Dictionary<CharacterClass, List<string>>()
    {
        { CharacterClass.CLERIC, new List<string>
            {
                "DesignDataSpell:Id_Spell_HolyLight",
                "DesignDataSpell:Id_Spell_HolyStrike",
                "DesignDataSpell:Id_Spell_LesserHeal",
                "DesignDataSpell:Id_Spell_LocustsSwarm",
                "DesignDataSpell:Id_Spell_Protection",
                "DesignDataSpell:Id_Spell_Resurrection",
                "DesignDataSpell:Id_Spell_Sanctuary",
                "DesignDataSpell:Id_Spell_BindEvil",
                "DesignDataSpell:Id_Spell_Bless",
                "DesignDataSpell:Id_Spell_Cleanse",
                "DesignDataSpell:Id_Spell_DivineStrike",
                "DesignDataSpell:Id_Spell_Earthquake"
            }
        },
        { CharacterClass.WIZARD, new List<string>
            {
                "DesignDataSpell:Id_Spell_Fireball",
                "DesignDataSpell:Id_Spell_Haste",
                "DesignDataSpell:Id_Spell_IceBolt",
                "DesignDataSpell:Id_Spell_Ignite",
                "DesignDataSpell:Id_Spell_Invisibility",
                "DesignDataSpell:Id_Spell_Light",
                "DesignDataSpell:Id_Spell_LightningStrike",
                "DesignDataSpell:Id_Spell_Lazy",
                "DesignDataSpell:Id_Spell_Zap",
                "DesignDataSpell:Id_Spell_MagicMissile",
                "DesignDataSpell:Id_Spell_ChainLightning"
            }
        }
    };
}

List<string> clericSpells = SpellData.Spells[CharacterClass.CLERIC];
List<string> wizardSpells = SpellData.Spells[CharacterClass.WIZARD];
