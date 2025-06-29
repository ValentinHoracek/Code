namespace Memento
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DrinkConfig config = new DrinkConfig
            {
                Type = "Espresso",
                Milk = 0,
                Sugar = 1
            };

            DrinkHistory history = new();

            config.Print();
            history.Backup(config);

            config.Type = "Latte";
            config.Milk = 2;
            config.Sugar = 0;

            config.Print();
            history.Backup(config);

            config.Type = "Mocha";
            config.Milk = 3;
            config.Sugar = 2;

            config.Print();

            Console.WriteLine("Undoing...");
            history.Undo(config);
            config.Print();

            Console.WriteLine("Undoing again...");
            history.Undo(config);
            config.Print();
        }
    }
}
