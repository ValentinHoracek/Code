namespace Bridge
{
    public class DrinkMachine
    {
        protected readonly IBrewer _brewer;

        public DrinkMachine(IBrewer brewer)
        {
            _brewer = brewer;
        }

        public virtual void MakeDrink()
        {
            _brewer.Brew();
        }
    }
}
