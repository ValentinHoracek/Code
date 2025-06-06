namespace Builder
{
    public class CoffeeOrderBuilder
    {

        private readonly CoffeeOrder _coffeeOrder = new();

        public CoffeeOrderBuilder SetSize(string size)
        {
            _coffeeOrder.Size = size;
            return this;
        }

        public CoffeeOrderBuilder AddMilk()
        {
            _coffeeOrder.HasMilk = true;
            return this;
        }

        public CoffeeOrderBuilder AddSugar()
        {
            _coffeeOrder.HasSugar = true;
            return this;
        }

        public CoffeeOrderBuilder AddExtra(string extra)
        {
            _coffeeOrder.Extras.Add(extra);
            return this;
        }

        public CoffeeOrder Build()
        {
            return _coffeeOrder;
        }
    }
}
