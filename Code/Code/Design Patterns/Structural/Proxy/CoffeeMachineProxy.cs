namespace Proxy
{
    public class CoffeeMachineProxy : ICoffeeMachine
    {
        private readonly RealCoffeeMachine _realMachine = new();
        private readonly bool _authorized;

        public CoffeeMachineProxy(bool authorized)
        {
            _authorized = authorized;
        }

        public void BrewCoffee(string type)
        {
            if (!_authorized && type == "VIP Espresso")
            {
                Console.WriteLine("[Proxy] Access denied: VIP Espresso requires authorization.");
                return;
            }

            Console.WriteLine("[Proxy] Access granted.");
            _realMachine.BrewCoffee(type);
        }
    }

}
