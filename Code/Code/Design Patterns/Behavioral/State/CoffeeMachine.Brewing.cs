namespace State
{
    public partial class CoffeeMachine
    {
        private class Brewing : IState
        {
            public string Name => "Brewing";

            public void StartBrew(CoffeeMachine machine)
            {
                Console.WriteLine("Already brewing.");
            }

            public void Clean(CoffeeMachine machine)
            {
                Console.WriteLine("Cannot clean while brewing.");
            }

            public void ReportError(CoffeeMachine machine)
            {
                Console.WriteLine("Error reported during brewing.");
                machine._state = new Error();
            }
        }
    }
}