namespace TemplateMethod
{
    public class FrenchPressBrewing : CoffeeBrewingProcess
    {
        protected override void PrepareCoffee()
        {
            Console.WriteLine("Coarsely grinding coffee beans.");
        }

        protected override void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee by steeping.");
        }
    }
}
