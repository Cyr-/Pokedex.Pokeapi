using Pokedex.Pokeapi.Utility;

namespace Pokedex.Pokeapi.Common
{
    public class Name
    {
        public string Text { get; set; }
        public NamedApiResource<Language> Language { get; set; }
    }
}