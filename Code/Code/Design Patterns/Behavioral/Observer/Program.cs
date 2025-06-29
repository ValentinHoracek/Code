using Observer.Observers;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new();

            MobileApp mobileApp = new();
            MaintenanceSystem maintenanceSystem = new();

            coffeeMachine.Attach(mobileApp);
            coffeeMachine.Attach(maintenanceSystem);

            coffeeMachine.StartBrew();
        }
    }
}
