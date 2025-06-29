namespace Interpreter.Expressions
{
    public class Brew : IExpression
    {
        private int shots;
        public Brew(int shots) => this.shots = shots;
        public void Interpret(CoffeeMachineContext context) => context.Brew(shots);
    }
}
