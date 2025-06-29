namespace Interpreter
{
    public interface IExpression
    {
        void Interpret(CoffeeMachineContext context);
    }
}
