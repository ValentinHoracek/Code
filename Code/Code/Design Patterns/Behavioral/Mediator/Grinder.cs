namespace Mediator
{
    public class Grinder : Colleague
    {
        public Grinder(ICoffeeMachineMediator mediator) : base(mediator) { }

        public override void Start()
        {
            Console.WriteLine("Grinding beans...");
            Mediator.StartHeating();
        }
    }
}