using Pokedex.Pokeapi.Common;

namespace Pokedex.Pokeapi.Pokemon
{
    public class TypePokemon
    {
        public int Slot { get; set; }
        public NamedApiResource<Pokemon> Pokemon { get; set; }
    }
}