using Pokedex.Pokeapi.Common;
using Pokedex.Pokeapi.Moves;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Pokemon
{
    public class PokemonMove
    {
        public NamedApiResource<Move> Move { get; set; }
        public List<PokemonMoveVersion> VersionGroupDetails { get; set; }
    }
}