namespace Prototype
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Original recipe
            CoffeeRecipe espresso = new()
            {
                Name = "Espresso",
                WaterMl = 30,
                CoffeeGrams = 7,
                HasMilk = false
            };

            // Clone to create a new one
            CoffeeRecipe macchiato = (CoffeeRecipe)espresso.Clone();
            macchiato.Name = "Macchiato";
            macchiato.HasMilk = true;

            espresso.Print();
            macchiato.Print();
        }
    }
}
