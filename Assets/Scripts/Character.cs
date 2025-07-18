using System;

public abstract class Character {
    public enum STAR {
        NONE = -1,
        FOUR = 4,
        FIVE = 5,
        SIX = 6
    }

    public enum ESSENCE_TYPE {
        NONE = -1,
        EARTH,
        WATER,
        ELECTRICITY,
        AIR,
        FIRE,
        ICE,
        LIGHT,
        DARKNESS
    }

    public enum WEAPON_TYPE {
        NONE = -1,
        SWORD,
        CLAYMORE,
        POLEARM,
        BOW,
        MAGIC
    }

    public string charName;
    public STAR star;
    public ESSENCE_TYPE essenceType;
    public WEAPON_TYPE weaponType;
    public int maxLP, maxEP, maxMP, maxUP, maxPotion;
    public int LP, EP, MP, UP, potion;

    // This variable represents Factors as a bitfield    
    STATUS_EFFECT statusEffects;

    // |   : Bitwise OR (set flag)              -> statusEffects |= STATUS_EFFECT.Burning;
    // &= ~: Bitwise AND with NOT (remove flag) -> statusEffects &= ~STATUS_EFFECT.Burning;
    // &   : Bitwise AND (check flag)           -> (statusEffects & STATUS_EFFECT.Burning) != 0

    [Flags]
    public enum STATUS_EFFECT {
        None = 0,
        Toughness = 1,
        Healing = 2,
        Recharge = 4,
        Growth = 8,
        Storm = 16,
        Burning = 32,
        Freeze = 64,
        Immune = 128
    }
}

// Helper method to check if a specific status effect is present (use on statusEffects)
// It ANDs the statusEffects with a specific effect to know if that specific effect is set
public static class StatusEffectResolver {
    public static bool Has ( this Character.STATUS_EFFECT effects, Character.STATUS_EFFECT effect ) {
        return ( effects & effect ) != 0;
    }
}
