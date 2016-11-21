using Newtonsoft.Json;
using Pokedex.Pokeapi.Utility;

namespace Pokedex.Pokeapi.Pokemon
{
    public class Genus
    {
        [JsonProperty("Genus")]
        public string Name { get; set; }
        public Language Language { get; set; }
    }
}