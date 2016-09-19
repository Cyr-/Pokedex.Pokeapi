using Pokedex.Pokeapi.Games;
using Pokedex.Pokeapi.Machines;

namespace Pokedex.Pokeapi.Common
{
    public class MachineVersionDetail
    {
        public Machine Machine { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}