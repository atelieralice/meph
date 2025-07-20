using System;

// This file is for getting character data from a json and handling it in a way that can be used by the game
namespace meph {

    [Serializable]
    public class CharacterData {
        public string charName;
        public int star;
        public string essenceType;
        public string weaponType;

        public int maxLP;
        public int maxEP;
        public int maxMP;
        public int maxUP;
        public int maxPotion;
    }
}