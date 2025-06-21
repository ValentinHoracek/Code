namespace Adapter
{
    public class EspressoAdapter : IBrewable
    {
        private readonly ModernEspressoMachine _espressoMachine;

        public EspressoAdapter(ModernEspressoMachine espressoMachine)
        {
            _espressoMachine = espressoMachine;
        }

        public void MakeCoffee()
        {
            _espressoMachine.StartBrew(); // adapt incompatible method
        }
    }
}
