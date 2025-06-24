namespace Flyweight
{
    public class Type
    {
        public string Name { get; }
        public bool HasMilk { get; }

        public Type(string name, bool hasMilk)
        {
            Name = name;
            HasMilk = hasMilk;
        }

        public void Serve(int orderId)
        {
            Console.WriteLine($"Serving {Name} (Milk: {HasMilk}) for Order #{orderId}");
        }
    }
}
