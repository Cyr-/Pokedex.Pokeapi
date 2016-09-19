using Pokedex.Pokeapi.Games;

namespace Pokedex.Pokeapi.Pokemon
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMainSeries { get; set; }
        public Generation Generation { get; set; }
    }
}