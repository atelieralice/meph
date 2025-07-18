public class Character {
    public string charName;

    public enum WEAPON {
        NONE = -1,
        SWORD,
        CLAYMORE,
        POLEARM,
        BOW,
        MAGIC
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

    public enum STAR {
        NONE = -1,
        FOUR = 4,
        FIVE = 5,
        SIX = 6
    }

    public int maxLP;
    public int maxEP;
    public int maxMP;
    public int maxUP;
    public int potion;

    bool isAffectedByToughness;
    bool isAffectedByHealing;
    bool isAffectedByRecharge;
    bool isAffectedByGrowth;
    bool isAffectedByStorm;
    bool isAffectedByBurning;
    bool isAffectedByFreeze;
    bool isImmune;

}