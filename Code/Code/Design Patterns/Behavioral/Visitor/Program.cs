namespace Visitor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ICoffeeMachinePart> parts = new()
        {
            new Grinder(),
            new Heater(),
            new Brewer()
        };

            ICoffeeMachineVisitor diagnostics = new DiagnosticsVisitor();

            foreach (ICoffeeMachinePart part in parts)
            {
                part.Accept(diagnostics);
            }
        }
    }
}
