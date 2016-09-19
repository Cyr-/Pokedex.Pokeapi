using Pokedex.Pokeapi.Common;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Moves
{
    public class MoveDamageClass : NamedApiObject
    {
        public List<Description> Descriptions { get; set; }
        public List<NamedApiResource<Move>> Moves { get; set; }
        public List<Name> Names { get; set; }
    }
}