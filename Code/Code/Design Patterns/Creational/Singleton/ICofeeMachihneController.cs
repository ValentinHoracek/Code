namespace Singleton
{
    public interface ICofeeMachihneController
    {
        void MakeCoffee(string recipeName);
        string GetCurrentStatus();
        void ShutdownMachine();
    }
}
