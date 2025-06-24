namespace Decorator
{
    public class Sugar : DrinkDecorator
    {
        public Sugar(IDrink drink) : base(drink) { }

        public override string GetDescription() => _baseDrink.GetDescription() + ", Sugar";
        public override double GetCost() => _baseDrink.GetCost() + 0.20;
    }
}
