namespace Interpreter
{
    public class CoffeeMachineContext
    {
        public void GrindBeans() => Console.WriteLine("Grinding beans...");
        public void HeatWater() => Console.WriteLine("Heating water...");
        public void Brew(int shots) => Console.WriteLine($"Brewing {shots} shot(s)...");
        public void AddMilk(int ml) => Console.WriteLine($"Adding {ml}ml of milk...");
        public void FrothMilk() => Console.WriteLine("Frothing milk...");
        public void Pour() => Console.WriteLine("Pouring drink...");
    }
}