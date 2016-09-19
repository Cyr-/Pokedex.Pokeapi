using System;

namespace Pokedex.Pokeapi.Common
{
    public interface IResource<T>
    {
        Uri Url { get; }
    }
}