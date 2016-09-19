namespace Pokedex.Pokeapi.Common
{
    public class NamedApiResource<T> : ApiResource<T> where T : NamedApiObject
    {
        public string Name { get; set; }
    }
}