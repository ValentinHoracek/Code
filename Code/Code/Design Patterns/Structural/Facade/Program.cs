namespace Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeFacade coffeeFacade = new();
            coffeeFacade.MakeCoffee();
        }
    }
}
