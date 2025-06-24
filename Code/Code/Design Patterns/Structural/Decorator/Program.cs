namespace Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDrink drink = new Espresso();
            drink = new Milk(drink);
            drink = new Sugar(drink);

            Console.WriteLine(drink.GetDescription()); // Espresso, Milk, Sugar
            Console.WriteLine($"Total: ${drink.GetCost():0.00}");
        }
    }
}
