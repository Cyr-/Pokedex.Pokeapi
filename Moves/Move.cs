using Pokedex.Pokeapi.Common;
using Pokedex.Pokeapi.Games;
using Pokedex.Pokeapi.Pokemon;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Moves
{
    public class Move : NamedApiObject
    {
        public int Accuracy { get; set; }
        public int EffectChance { get; set; }
        public int PP { get; set; }
        public int Priority { get; set; }
        public int Power { get; set; }
        public MoveDamageClass DamageClass { get; set; }
        public List<VerboseEffect> EffectEntries { get; set; }
        public List<AbilityEffectChange> EffectChanges { get; set; }
        public Move FlavourTextEntries { get; set; }
        public Generation Generation { get; set; }
        public MachineVersionDetail Machines { get; set; }
        public MoveMetaData Meta { get; set; }
        public MoveStatChange StatChanges { get; set; }
        public MoveTarget Target { get; set; }
        public Type Type { get; set; }
    }
}