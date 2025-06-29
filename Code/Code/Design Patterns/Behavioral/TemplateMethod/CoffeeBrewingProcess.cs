namespace TemplateMethod
{
    public abstract class CoffeeBrewingProcess
    {
        public void Brew()
        {
            HeatWater();
            PrepareCoffee();
            BrewCoffee();
            AddExtras();
            Serve();
        }

        protected virtual void HeatWater()
        {
            Console.WriteLine("Heating water to standard temperature.");
        }

        protected abstract void PrepareCoffee();
        protected abstract void BrewCoffee();

        protected virtual void AddExtras()
        {
            Console.WriteLine("No extras added.");
        }

        protected virtual void Serve()
        {
            Console.WriteLine("Serving coffee.");
        }
    }
}
