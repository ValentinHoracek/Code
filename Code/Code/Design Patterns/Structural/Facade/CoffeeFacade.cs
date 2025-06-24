namespace Facade
{
    public class CoffeeFacade
    {
        private readonly Grinder _grinder = new();
        private readonly Boiler _boiler = new();
        private readonly Brewer _brewer = new();

        public void MakeCoffee()
        {
            _grinder.GrindBeans();
            _boiler.HeatWater();
            _brewer.Brew();
        }
    }

}
