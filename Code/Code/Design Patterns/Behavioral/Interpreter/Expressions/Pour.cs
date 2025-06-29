namespace Interpreter.Expressions
{
    public class Pour : IExpression
    {
        public void Interpret(CoffeeMachineContext context) => context.Pour();
    }
}
