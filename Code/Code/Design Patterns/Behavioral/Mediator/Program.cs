namespace Mediator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachineMediator mediator = new();

            mediator.Grinder.Start();
        }
    }
}
