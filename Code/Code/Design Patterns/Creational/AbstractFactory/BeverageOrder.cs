namespace AbstractFactory
{
    public class BeverageOrder
    {
        public IBeverage Beverage { get; set; }
        public ICondiment Condiment { get; set; }

        public BeverageOrder(IBeverageFactory factory)
        {
            Beverage = factory.CreateBeverage();
            Condiment = factory.CreateCondiment();
        }

        public void Serve()
        {
            Console.WriteLine($"Serving {Beverage.Describe()} with {Condiment.Describe()}");
        }
    }
}
