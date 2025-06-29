namespace State
{
    public partial class CoffeeMachine
    {
        private class Error : IState
        {
            public string Name => "Error";

            public void StartBrew(CoffeeMachine machine)
            {
                Console.WriteLine("Cannot start brewing: machine in error state.");
            }

            public void Clean(CoffeeMachine machine)
            {
                Console.WriteLine("Cannot clean: machine in error state.");
            }

            public void ReportError(CoffeeMachine machine)
            {
                Console.WriteLine("Already in error state.");
            }
        }
    }
}