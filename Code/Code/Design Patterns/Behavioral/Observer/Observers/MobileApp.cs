namespace Observer.Observers
{
    public class MobileApp : ICoffeeObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"MobileApp received update: {message}");
        }
    }
}
