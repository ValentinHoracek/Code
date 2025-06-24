namespace Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ingredient espresso = new("Espresso");
            Ingredient milk = new("Milk");

            Drink latte = new("Latte");
            latte.AddComponent(espresso);
            latte.AddComponent(milk);

            latte.Display();
        }
    }
}
