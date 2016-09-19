using Pokedex.Pokeapi.Common;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int FlingPower { get; set; }
        public List<ItemFlingEffect> FlingEffect { get; set; }
        public List<ItemAttribute> Attributes { get; set; }
        public ItemCategory Category { get; set; }
        public VerboseEffect EffectEntries { get; set; }
    }
}