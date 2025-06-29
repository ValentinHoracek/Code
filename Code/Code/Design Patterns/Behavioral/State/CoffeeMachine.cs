namespace State
{
    public partial class CoffeeMachine
    {
        private IState _state = new Idle();

        public string CurrentState => _state.Name;

        public void StartBrew()
        {
            _state.StartBrew(this);
        }

        public void Clean()
        {
            _state.Clean(this);
        }

        public void ReportError()
        {
            _state.ReportError(this);
        }
    }
}