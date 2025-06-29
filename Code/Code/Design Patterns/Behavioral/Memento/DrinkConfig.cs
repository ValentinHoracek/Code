namespace Memento
{
    public class DrinkConfig
    {
        public string Type { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }

        public DrinkConfigSnapshot Save()
        {
            Console.WriteLine("Saving configuration...");
            return new DrinkConfigSnapshot(Type, Milk, Sugar);
        }

        public void Restore(DrinkConfigSnapshot snapshot)
        {
            Console.WriteLine("Restoring configuration...");
            Type = snapshot.Type;
            Milk = snapshot.Milk;
            Sugar = snapshot.Sugar;
        }

        public void Print() =>
            Console.WriteLine($"Drink: {Type}, Milk: {Milk}, Sugar: {Sugar}");
    }
}
