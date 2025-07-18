using System;

public abstract class Character {
    public enum STAR {
        NONE = -1,
        FOUR = 4,
        FIVE = 5,
        SIX = 6
    }

    public enum ESSENCE {
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

    public enum WEAPON {
        NONE = -1,
        SWORD,
        CLAYMORE,
        POLEARM,
        BOW,
        MAGIC
    }

    public string charName;
    public STAR star;
    public ESSENCE essenceType;
    public WEAPON weaponType;

    public int maxLP, maxEP, maxMP, maxUP, potionAmount;

    // public bool isAffectedByToughness;
    // public bool isAffectedByHealing;
    // public bool isAffectedByRecharge;
    // public bool isAffectedByGrowth;
    // public bool isAffectedByStorm;
    // public bool isAffectedByBurning;
    // public bool isAffectedByFreeze;
    // public bool isImmune;
}

