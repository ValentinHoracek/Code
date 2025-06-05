namespace Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachineController.Instance.MakeCoffee("Espresso");

            string status = CoffeeMachineController.Instance.GetCurrentStatus();
            Console.WriteLine($"Machine status: {status}");
        }
    }
}
