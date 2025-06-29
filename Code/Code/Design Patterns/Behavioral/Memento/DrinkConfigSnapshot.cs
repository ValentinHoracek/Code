namespace Memento
{
    public class DrinkConfigSnapshot
    {
        public string Type { get; }
        public int Milk { get; }
        public int Sugar { get; }

        public DrinkConfigSnapshot(string type, int milk, int sugar)
        {
            Type = type;
            Milk = milk;
            Sugar = sugar;
        }
    }
}
