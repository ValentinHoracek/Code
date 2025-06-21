using FactoryMethod.Service;

namespace FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DrinkMachine drinkMachine;

            drinkMachine = new TeaMachine();
            drinkMachine.ServeDrink();
            drinkMachine = new CoffeeMachine();
            drinkMachine.ServeDrink();
        }
    }
}
