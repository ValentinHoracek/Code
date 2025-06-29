namespace TemplateMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeBrewingProcess espresso = new EspressoBrewing();
            espresso.Brew();

            Console.WriteLine();

            CoffeeBrewingProcess frenchPress = new FrenchPressBrewing();
            frenchPress.Brew();
        }
    }
}
