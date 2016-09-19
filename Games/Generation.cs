using Pokedex.Pokeapi.Moves;
using Pokedex.Pokeapi.Pokemon;
using Pokedex.Pokeapi.Common;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Games
{
    public class Generation : NamedApiObject
    {
        public List<Ability> Abilities { get; set; }
        public List<Move> Moves { get; set; }
        public List<PokemonSpecies> PokemonSpecies { get; set; }
        public List<Type> Types { get; set; }
    }
}