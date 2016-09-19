using Pokedex.Pokeapi.Common;
using System.Collections.Generic;

namespace Pokedex.Pokeapi.Pokemon
{
    public class TypeRelations
    {
        public List<NamedApiResource<Type>> NoDamageTo { get; set; }
        public List<NamedApiResource<Type>> HalfDamageTo { get; set; }
        public List<NamedApiResource<Type>> DoubleDamageTo { get; set; }
        public List<NamedApiResource<Type>> NoDamageFrom { get; set; }
        public List<NamedApiResource<Type>> HalfDamageFrom { get; set; }
        public List<NamedApiResource<Type>> DoubleDamageFrom { get; set; }
    }
}