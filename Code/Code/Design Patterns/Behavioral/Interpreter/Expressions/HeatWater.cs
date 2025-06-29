namespace Interpreter.Expressions
{
    public class HeatWater : IExpression
    {
        public void Interpret(CoffeeMachineContext context) => context.HeatWater();
    }
}
