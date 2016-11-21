using System.Collections.Generic;
using Pokedex.Pokeapi.Common;

namespace Pokedex.Pokeapi.Pokemon
{
    public class Pokemon : NamedApiObject
    {
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }
        public List<PokemonForm> Forms { get; set; }
        public List<VersionGameIndex> GameIndicies { get; set; }
        public List<PokemonHeldItem> HeldItems { get; set; }
        public string LocationAreaEncounters { get; set; }
        public List<PokemonMove> Moves { get; set; }
        public PokemonSprites Sprites { get; set; }
        public PokemonSpecies Species { get; set; }
        public List<PokemonStat> Stats { get; set; }
        public List<PokemonType> Types { get; set; }
    }
}