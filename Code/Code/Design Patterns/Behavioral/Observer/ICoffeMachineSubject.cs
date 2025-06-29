namespace Observer
{
    public interface ICoffeMachineSubject
    {
        void Attach(ICoffeeObserver observer);
        void Detach(ICoffeeObserver observer);
        void Notify(string message);
    }
}
