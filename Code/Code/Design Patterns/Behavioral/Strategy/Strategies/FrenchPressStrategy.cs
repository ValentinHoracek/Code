namespace Strategy.Strategies
{
    public class FrenchPressStrategy : IBrewStrategy
    {
        public void Brew()
        {
            Console.WriteLine("Brewing French press coffee...");
        }
    }
}
