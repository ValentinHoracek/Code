namespace Visitor
{
    public class DiagnosticsVisitor : ICoffeeMachineVisitor
    {
        public void Visit(Grinder grinder)
        {
            Console.WriteLine("Checking Grinder: grinding speed normal.");
        }

        public void Visit(Heater heater)
        {
            Console.WriteLine("Checking Heater: temperature stable.");
        }

        public void Visit(Brewer brewer)
        {
            Console.WriteLine("Checking Brewer: brewing pressure optimal.");
        }
    }
}
