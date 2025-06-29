namespace Interpreter.Expressions
{
    public class GrindBeans : IExpression
    {
        public void Interpret(CoffeeMachineContext context) => context.GrindBeans();
    }
}
