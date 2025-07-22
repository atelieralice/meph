using System.IO;
using Newtonsoft.Json;

namespace meph {
    public static class CharacterLoader {
        public static CharacterData LoadCharacter ( string path ) {
            string json = File.ReadAllText ( path );
            return JsonConvert.DeserializeObject<CharacterData> ( json );
        }
    }
}

// TODO: Load the json Unity way