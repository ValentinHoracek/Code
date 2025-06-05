namespace Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICofeeMachihneController coffeeMachine = CoffeeMachineController.Instance;
            coffeeMachine.MakeCoffee("Espresso");

            string status = coffeeMachine.GetCurrentStatus();
            Console.WriteLine($"Machine status: {status}");
        }
    }
}
