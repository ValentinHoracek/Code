namespace Builder
{
    public class BeverageDirector
    {
        private readonly BeverageBuilder _builder = new();

        // Fluent API - each method return instance of itself.
        public BeverageOrder BuildCofee()
        {
            return _builder
                .Reset()
                .SetSize("Large")
                .BuildCoffee()
                .AddMilk()
                .AddSugar()
                .AddExtra("Vanilla Syrup")
                .Build();
        }

        public BeverageOrder BuildTea()
        {
            _builder.Reset();
            _builder.SetSize("Medium");
            _builder.BuildTea();
            _builder.AddSugar();
            _builder.AddExtra("Lemon");
            _builder.Build();

            return _builder.Order;
        }
    }
}
