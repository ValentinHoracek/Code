namespace State
{
    public partial class CoffeeMachine
    {
        private interface IState
        {
            string Name { get; }

            void StartBrew(CoffeeMachine machine);
            void Clean(CoffeeMachine machine);
            void ReportError(CoffeeMachine machine);
        }
    }
}
