using Pokedex.Pokeapi.Common;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Items
{
    public class ItemFlingEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Effect> EffectEntries { get; set; }
        public List<Item> Items { get; set; }
    }
}