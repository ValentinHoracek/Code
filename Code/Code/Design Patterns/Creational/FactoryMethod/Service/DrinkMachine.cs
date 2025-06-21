using FactoryMethod.Client;

namespace FactoryMethod.Service
{
    public abstract class DrinkMachine
    {
        public abstract IDrink CreateDrink();

        public void ServeDrink()
        {
            IDrink drink = CreateDrink();
            drink.Prepare();
        }
    }
}
