namespace Command
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new();
            Invoker invoker = new();

            OrderEspresso makeEspresso = new() { Receiver = coffeeMachine };
            OrderLatte makeLatte = new() { Receiver = coffeeMachine };

            List<ICommand> commands = new() { makeEspresso, makeLatte };
            invoker.Execute(commands);
            invoker.Execute(makeEspresso);
            invoker.Execute(makeEspresso);
            invoker.Execute(makeEspresso);
            invoker.CompensateLast();
            invoker.CompensateLast();
        }
    }
}
