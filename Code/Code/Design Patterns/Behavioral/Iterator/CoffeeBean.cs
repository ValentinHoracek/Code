namespace Iterator
{
    public class CoffeeBean
    {
        public string Name { get; }
        public string Origin { get; }

        public CoffeeBean(string name, string origin)
        {
            Name = name;
            Origin = origin;
        }
    }
}