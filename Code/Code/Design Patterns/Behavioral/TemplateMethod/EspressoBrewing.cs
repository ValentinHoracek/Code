namespace TemplateMethod
{
    public class EspressoBrewing : CoffeeBrewingProcess
    {
        protected override void PrepareCoffee()
        {
            Console.WriteLine("Grinding espresso beans finely.");
        }

        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing espresso under high pressure.");
        }

        protected override void AddExtras()
        {
            Console.WriteLine("Adding a small amount of milk.");
        }
    }
}
