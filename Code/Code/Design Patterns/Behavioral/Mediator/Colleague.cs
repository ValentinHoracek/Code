namespace Mediator
{
    public abstract class Colleague
    {
        protected ICoffeeMachineMediator Mediator;

        public Colleague(ICoffeeMachineMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Start();
    }
}