using System;

namespace Pokedex.Pokeapi.Common
{
    public class ApiResource<T> : IResource<T> where T : ApiObject
    {
        public Uri Url { get; set; }
    }
}