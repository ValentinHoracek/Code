namespace Command
{
    public interface ICommand
    {
        public bool IsCompensable { get; }
        void Execute();
        void Compensate();
    }
}
