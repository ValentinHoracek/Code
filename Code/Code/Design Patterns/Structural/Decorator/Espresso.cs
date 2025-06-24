namespace Decorator
{
    public class Espresso : IDrink
    {
        public string GetDescription() => "Espresso";
        public double GetCost() => 1.50;
    }
}
