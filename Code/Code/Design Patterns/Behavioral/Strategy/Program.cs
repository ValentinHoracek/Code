using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine machine = new(new EspressoStrategy());
            machine.Brew();

            machine.SetBrewStrategy(new FrenchPressStrategy());
            machine.Brew();

            machine.SetBrewStrategy(new ColdBrewStrategy());
            machine.Brew();
        }
    }
}
