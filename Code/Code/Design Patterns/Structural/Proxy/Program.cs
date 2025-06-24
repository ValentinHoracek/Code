namespace Proxy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICoffeeMachine guestMachine = new CoffeeMachineProxy(authorized: false);
            ICoffeeMachine vipMachine = new CoffeeMachineProxy(authorized: true);

            guestMachine.BrewCoffee("Latte");
            guestMachine.BrewCoffee("VIP Espresso");

            Console.WriteLine();

            vipMachine.BrewCoffee("VIP Espresso");
            vipMachine.BrewCoffee("Cappuccino");
        }
    }
}
