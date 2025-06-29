namespace Strategy.Strategies
{
    public class ColdBrewStrategy : IBrewStrategy
    {
        public void Brew()
        {
            Console.WriteLine("Brewing cold brew coffee...");
        }
    }
}
