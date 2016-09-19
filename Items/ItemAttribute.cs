using System.Collections.Generic;

namespace Pokedex.Pokeapi.Items
{
    public class ItemAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}