namespace State
{
    public partial class CoffeeMachine
    {
        private class Idle : IState
        {
            public string Name => "Idle";

            public void StartBrew(CoffeeMachine machine)
            {
                Console.WriteLine("Starting brewing process...");
                machine._state = new Brewing();
            }

            public void Clean(CoffeeMachine machine)
            {
                Console.WriteLine("Cannot clean while idle.");
            }

            public void ReportError(CoffeeMachine machine)
            {
                Console.WriteLine("Error reported while idle.");
                machine._state = new Error();
            }
        }
    }
}
