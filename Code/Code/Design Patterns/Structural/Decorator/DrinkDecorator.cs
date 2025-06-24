namespace Decorator
{
    public abstract class DrinkDecorator : IDrink
    {
        protected readonly IDrink _baseDrink;

        protected DrinkDecorator(IDrink drink) => _baseDrink = drink;

        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
