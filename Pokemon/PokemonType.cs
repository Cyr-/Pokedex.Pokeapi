using Pokedex.Pokeapi.Common;

namespace Pokedex.Pokeapi.Pokemon
{
    public class PokemonType
    {
        public int Slot { get; set; }
        public NamedApiResource<Type> Type { get; set; }
    }
}