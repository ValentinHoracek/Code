namespace Proxy
{
    public class RealCoffeeMachine : ICoffeeMachine
    {
        public void BrewCoffee(string type)
        {
            Console.WriteLine($"[Machine] Brewing {type}...");
        }
    }

}
