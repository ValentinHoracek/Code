namespace Flyweight
{
    public class TypeFactory
    {
        private readonly Dictionary<string, Type> _cache = [];

        public Type GetCoffeeType(string name, bool hasMilk)
        {
            string key = $"{name}_{hasMilk}";
            if (!_cache.ContainsKey(key))
            { 
                _cache[key] = new Type(name, hasMilk);
            }

            return _cache[key];
        }

        public int Count => _cache.Count;
    }
}
