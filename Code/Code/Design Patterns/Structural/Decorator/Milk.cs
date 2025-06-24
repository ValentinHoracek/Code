namespace Decorator
{
    public class Milk : DrinkDecorator
    {
        public Milk(IDrink drink) : base(drink) { }

        public override string GetDescription() => _baseDrink.GetDescription() + ", Milk";
        public override double GetCost() => _baseDrink.GetCost() + 0.30;
    }
}
