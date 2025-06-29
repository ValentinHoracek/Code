namespace Visitor
{
    public interface ICoffeeMachinePart
    {
        void Accept(ICoffeeMachineVisitor visitor);
    }
}
