using FactoryMethod.Client;

namespace FactoryMethod.Service
{
    public class CoffeeMachine : DrinkMachine
    {
        public override IDrink CreateDrink()
        {
            return new Coffee();
        }
    }
}
