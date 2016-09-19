using Pokedex.Pokeapi.Common;
using Pokedex.Model.Evolution;
using Pokedex.Pokeapi.Games;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Pokemon
{
    public class PokemonSpecies : NamedApiObject
    {
        public int Order { get; set; }
        public int GenderRate { get; set; }
        public int CaptureRate { get; set; }
        public int BaseHappiness { get; set; }
        public bool IsBaby { get; set; }
        public int HatchCounter { get; set; }
        public bool HasGenderDifferences { get; set; }
        public bool FormsSwitchable { get; set; }
        public NamedApiResource<GrowthRate> GrowthRate { get; set; }
        public List<PokemonSpeciesDexEntry> PokedexNumbers { get; set; }
        public List<NamedApiResource<EggGroup>> EggGroups { get; set; }
        public NamedApiResource<PokemonColor> Color { get; set; }
        public NamedApiResource<PokemonShape> Shape { get; set; }
        public NamedApiResource<PokemonSpecies> EvolvesFromSpecies { get; set; }
        public ApiResource<EvolutionChain> EvolutionChain { get; set; }
        public NamedApiResource<PokemonHabitat> Habitat { get; set; }
        public NamedApiResource<Generation> Generation { get; set; }
        public List<Name> Names { get; set; }
        public List<PalParkEncounterArea> PalParkEncounters { get; set; }
        public List<FlavorText> FlavorTextEntries { get; set; }
        public List<Description> FormDescriptions { get; set; }
        public List<Genus> Genera { get; set; }
        public List<PokemonSpeciesVariety> Varieties { get; set; }
    }
}