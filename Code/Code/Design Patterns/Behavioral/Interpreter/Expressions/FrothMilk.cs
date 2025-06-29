namespace Interpreter.Expressions
{
    public class FrothMilk : IExpression
    {
        public void Interpret(CoffeeMachineContext context) => context.FrothMilk();
    }
}
