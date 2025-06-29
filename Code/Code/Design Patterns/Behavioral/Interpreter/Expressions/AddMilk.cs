namespace Interpreter.Expressions
{
    public class AddMilk : IExpression
    {
        private int ml;
        public AddMilk(int ml) => this.ml = ml;
        public void Interpret(CoffeeMachineContext context) => context.AddMilk(ml);
    }
}
