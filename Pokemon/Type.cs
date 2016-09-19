using Pokedex.Pokeapi.Common;
using Pokedex.Pokeapi.Moves;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Pokemon
{
    public class Type : NamedApiObject
    {
        public TypeRelations DamageRelations { get; set; }
        public List<GenerationGameIndex> GameIndices { get; set; }
        public NamedApiResource<MoveDamageClass> MoveDamageClass { get; set; }
        public List<TypePokemon> Pokemon { get; set; }
        public List<NamedApiResource<Move>> Moves { get; set; }
    }
}