namespace Mediator
{
    public class Brewer : Colleague
    {
        public Brewer(ICoffeeMachineMediator mediator) : base(mediator) { }

        public override void Start()
        {
            Console.WriteLine("Brewing coffee...");
        }
    }
}