namespace Visitor
{
    public class Brewer : ICoffeeMachinePart
    {
        public void Accept(ICoffeeMachineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}