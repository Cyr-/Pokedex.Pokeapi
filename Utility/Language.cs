using System.Collections.Generic;
using Pokedex.Pokeapi.Common;

namespace Pokedex.Pokeapi.Utility
{
    public class Language : NamedApiObject
    {
        public bool Official { get; set; }
        public string Iso639 { get; set; }
        public string Iso3166 { get; set; }
        public List<Name> Names { get; set; }
    }
}