namespace Visitor
{
    public interface ICoffeeMachineVisitor
    {
        void Visit(Grinder grinder);
        void Visit(Heater heater);
        void Visit(Brewer brewer);
    }
}
