namespace Visitor
{
    public class Grinder : ICoffeeMachinePart
    {
        public void Accept(ICoffeeMachineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}