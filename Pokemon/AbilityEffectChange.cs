using Pokedex.Pokeapi.Common;
using Pokedex.Pokeapi.Games;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Pokemon
{
    public class AbilityEffectChange
    {
        public List<Effect> EffectEntries { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}