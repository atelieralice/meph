public abstract class Card {
    public string Name;
    public string Description;
}

public class WeaponCard : Card {
    public Character.WEAPON WeaponType;
    public int AttackPower;
}

public class SkillCard : Card {
    public enum Type { Q, W, E, U }
}

public class PotionCard : Card {
    public int Amount;
}

public class CharmCard : Card {
    public enum Type { Helmet, Armor, Gloves, Boots, Glow }
    public Type CharmType;
}