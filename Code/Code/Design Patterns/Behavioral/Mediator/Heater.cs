namespace Mediator
{
    public class Heater : Colleague
    {
        public Heater(ICoffeeMachineMediator mediator) : base(mediator) { }

        public override void Start()
        {
            Console.WriteLine("Heating water...");
            Mediator.StartBrewing();
        }
    }
}