namespace Bridge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IBrewer brewer = new EspressoBrewer();
            DrinkMachine drinkMachine = new DrinkMachine(brewer);
            drinkMachine.MakeDrink();
        }
    }
}
