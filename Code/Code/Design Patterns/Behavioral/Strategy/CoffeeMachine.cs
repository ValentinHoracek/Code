namespace Strategy
{
    public class CoffeeMachine
    {
        private IBrewStrategy _brewStrategy;

        public CoffeeMachine(IBrewStrategy brewStrategy)
        {
            _brewStrategy = brewStrategy;
        }

        public void SetBrewStrategy(IBrewStrategy brewStrategy)
        {
            _brewStrategy = brewStrategy;
        }

        public void Brew()
        {
            _brewStrategy.Brew();
        }
    }
}
