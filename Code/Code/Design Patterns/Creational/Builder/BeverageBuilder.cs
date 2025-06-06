namespace Builder
{
    public class BeverageBuilder
    {

        public BeverageOrder Order = new();

        // Resetig builder to start new recipe.
        public BeverageBuilder Reset()
        {
            Order = new();
            return this;
        }

        public BeverageBuilder SetSize(string size)
        {
            Order.Size = size;
            return this;
        }

        public BeverageBuilder BuildTea()
        {
            Order.Flavor = new Tea();
            return this;
        }

        public BeverageBuilder BuildCoffee()
        {
            Order.Flavor = new Coffee();
            return this;
        }

        public BeverageBuilder AddMilk()
        {
            Order.HasMilk = true;
            return this;
        }

        public BeverageBuilder AddSugar()
        {
            Order.HasSugar = true;
            return this;
        }

        public BeverageBuilder AddExtra(string extra)
        {
            Order.Extras.Add(extra);
            return this;
        }

        public BeverageOrder Build()
        {
            return Order;
        }
    }
}
