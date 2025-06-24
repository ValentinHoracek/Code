namespace Flyweight
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TypeFactory factory = new();
            List<Order> orders = [];
            Random rand = new();

            string[] names = ["Espresso", "Latte", "Americano", "Cappuccino"];

            for (int i = 1; i <= 100; i++)
            {
                string name = names[rand.Next(names.Length)];
                bool hasMilk = rand.Next(2) == 1;

                Type type = factory.GetCoffeeType(name, hasMilk);
                orders.Add(new Order(i, type));
            }

            foreach (var order in orders)
            {
                order.Serve();
            }

            Console.WriteLine($"\nTotal unique coffee types: {factory.Count}");
        }
    }
}
