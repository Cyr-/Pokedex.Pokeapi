using Pokedex.Pokeapi.Games;
using Pokedex.Pokeapi.Items;
using Pokedex.Pokeapi.Moves;

namespace Pokedex.Pokeapi.Machines
{
    public class Machine
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public Move Move { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}