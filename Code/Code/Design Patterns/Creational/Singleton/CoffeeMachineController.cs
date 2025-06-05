namespace Singleton
{
    public sealed class CoffeeMachineController : ICofeeMachihneController
    {
        // Lazy initialization for thread-safe, lazy-loaded Singleton
        private static readonly Lazy<CoffeeMachineController> _instance = new(() => new CoffeeMachineController());

        // Public accessor
        public static CoffeeMachineController Instance => _instance.Value;

        // Private constructor to prevent external instantiation
        private CoffeeMachineController()
        {
            InitializeMachine();
        }

        // Simulated state
        private string _status = "Idle";

        private void InitializeMachine()
        {
            // Simulate connection setup or hardware sync
            Console.WriteLine("Coffee Machine Initialized.");
        }

        // Example method: make a coffee
        public void MakeCoffee(string recipeName)
        {
            if (_status != "Idle")
            {
                Console.WriteLine($"Machine busy: current state is {_status}");
                return;
            }

            _status = "Brewing";
            Console.WriteLine($"Brewing: {recipeName}");
            Thread.Sleep(1000); // Simulate time delay
            _status = "Idle";
            Console.WriteLine("Coffee ready.");
        }

        // Example method: check status
        public string GetCurrentStatus()
        {
            return _status;
        }

        // Example method: shutdown
        public void ShutdownMachine()
        {
            Console.WriteLine("Coffee machine shutting down.");
        }
    }

    // Static initialization - thread safe
    //public sealed class CoffeeMachineController
    //{
    //    private static CoffeeMachineController _instance = new();

    //    public static CoffeeMachineController Instance => _instance;

    //    private CoffeeMachineController()
    //    {
    //    }

    //    public int GetDefaultAnswer()
    //    {
    //        return 42;
    //    }

    //}

    // Manual lazy initialization - not thread safe
    //public sealed class CoffeeMachineController
    //{
    //    private static CoffeeMachineController? _instance;

    //    public static CoffeeMachineController Instance
    //    {
    //        get
    //        {
    //            if (_instance is null)
    //            {
    //                _instance = new();
    //            }

    //            return _instance;
    //        }
    //    }

    //    private CoffeeMachineController()
    //    {
    //    }

    //    public int GetDefaultAnswer()
    //    {
    //        return 42;
    //    }

    //}

    // Lazy inicialization - thread safe

    //public sealed class CoffeeMachineController
    //{
    //    private static CoffeeMachineController? _instance;

    //    private static object _lock = new();

    //    public static CoffeeMachineController Instance
    //    {
    //        get
    //        {
    //            // Check if I need to lock at all (thread safety only if singleton is not yet set)
    //            if (_instance is null)
    //            {
    //                lock (_lock)
    //                {
    //                    // Double check locking -> if I should create an instance
    //                    if (_instance is null)
    //                    {
    //                        _instance = new();
    //                    }
    //                }
    //            }

    //            return _instance;
    //        }
    //    }

    //    private CoffeeMachineController()
    //    {
    //    }

    //    public int GetDefaultAnswer()
    //    {
    //        return 42;
    //    }

    //}

    // Lazy initialization with Lazy<T> - thread safe
    //public sealed class CoffeeMachineController
    //{
    //    private static Lazy<CoffeeMachineController> _instance = new(() => new CoffeeMachineController(), true);

    //    public static CoffeeMachineController Instance => _instance.Value;

    //    private CoffeeMachineController()
    //    {
    //    }

    //    public int GetDefaultAnswer()
    //    {
    //        return 42;
    //    }

    //}
}
