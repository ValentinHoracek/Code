namespace State
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine machine = new();

            Console.WriteLine($"Current state: {machine.CurrentState}");
            machine.StartBrew();

            Console.WriteLine($"Current state: {machine.CurrentState}");
            machine.Clean();

            machine.ReportError();
            Console.WriteLine($"Current state: {machine.CurrentState}");

            machine.StartBrew();
        }
    }
}
