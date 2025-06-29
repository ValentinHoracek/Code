namespace Observer
{
    public class CoffeeMachine : ICoffeMachineSubject
    {
        private List<ICoffeeObserver> _observers = new();

        public void Attach(ICoffeeObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(ICoffeeObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }

        public void StartBrew()
        {
            Console.WriteLine("CoffeeMachine: Brewing started.");
            Notify("Brew started");
        }
    }
}
