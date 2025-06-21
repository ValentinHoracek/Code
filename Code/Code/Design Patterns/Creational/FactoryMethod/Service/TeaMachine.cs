using FactoryMethod.Client;

namespace FactoryMethod.Service
{
    public class TeaMachine : DrinkMachine
    {
        public override IDrink CreateDrink()
        {
            return new Tea();
        }
    }
}
