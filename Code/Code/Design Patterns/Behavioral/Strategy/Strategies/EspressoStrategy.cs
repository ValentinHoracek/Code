namespace Strategy.Strategies
{
    public class EspressoStrategy : IBrewStrategy
    {
        public void Brew()
        {
            Console.WriteLine("Brewing espresso...");
        }
    }
}
