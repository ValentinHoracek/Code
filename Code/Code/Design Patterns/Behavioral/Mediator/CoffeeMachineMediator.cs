using System.Diagnostics.Metrics;
using System.Reflection;

namespace Mediator
{
    public class CoffeeMachineMediator : ICoffeeMachineMediator
    {
        public Grinder Grinder { get; }
        public Heater Heater { get; }
        public Brewer Brewer { get; }

        public CoffeeMachineMediator()
        {
            Grinder = new Grinder(this);
            Heater = new Heater(this);
            Brewer = new Brewer(this);
        }

        public void StartHeating()
        {
            Console.WriteLine("Mediator triggers heating.");
            Heater.Start();
        }

        public void StartBrewing()
        {
            Console.WriteLine("Mediator triggers brewing.");
            Brewer.Start();
        }
    }
}
