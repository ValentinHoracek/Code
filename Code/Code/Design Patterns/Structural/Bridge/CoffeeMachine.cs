namespace Bridge
{
    public class CoffeeMachine : DrinkMachine
    {
        public CoffeeMachine(IBrewer brewer) : base(brewer)
        {
        }

        public override void MakeDrink()
        {
            Console.WriteLine("Making coffee...");
            _brewer.Brew();
        }
    }
}
