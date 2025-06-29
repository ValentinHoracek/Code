namespace Observer.Observers
{
    public class MaintenanceSystem : ICoffeeObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Maintenance System received update: {message}");
        }
    }
}
