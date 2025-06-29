namespace Visitor
{
    public class Heater : ICoffeeMachinePart
    {
        public void Accept(ICoffeeMachineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}