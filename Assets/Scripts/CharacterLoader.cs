using UnityEngine;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace meph {
    public static class CharacterLoader {
        private static List<CharacterData> cachedCharacters = null;
        private static string cachedResourceName = null;

        public static List<CharacterData> LoadAllCharacters ( string resourceName ) {
            // Only reload if cache is empty
            if ( cachedCharacters != null && cachedResourceName == resourceName )
                return cachedCharacters;

            TextAsset jsonFile = Resources.Load<TextAsset> ( resourceName );
            if ( jsonFile == null ) {
                Debug.LogError ( $"Could not find resource: {resourceName}" );
                return null;
            }
            cachedCharacters = JsonConvert.DeserializeObject<List<CharacterData>> ( jsonFile.text );
            cachedResourceName = resourceName;
            return cachedCharacters;
        }

        public static CharacterData LoadCharacter ( string resourceName, string charName ) {
            var allCharacters = LoadAllCharacters ( resourceName );
            if ( allCharacters == null ) return null;
            var character = allCharacters.Find (
                c => c.charName.Equals ( charName, System.StringComparison.OrdinalIgnoreCase )
            );
            if ( character == null )
                Debug.LogWarning ( $"Character '{charName}' not found in '{resourceName}'" );
            return character;
        }
    }
}

