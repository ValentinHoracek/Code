namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IBrewable machine = new EspressoAdapter(new ModernEspressoMachine());
            machine.MakeCoffee(); // client uses standard interface
        }
    }
}
