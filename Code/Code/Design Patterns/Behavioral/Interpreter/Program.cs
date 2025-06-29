using Interpreter.Expressions;

namespace Interpreter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<IExpression> recipe = new()
            {
                new GrindBeans(),
                new HeatWater(),
                new Brew(1),
                new AddMilk(50),
                new FrothMilk(),
                new Pour(),
            };

            CoffeeMachineContext context = new();
            foreach (IExpression step in recipe)
            {
                step.Interpret(context);
            }
        }
    }
}
