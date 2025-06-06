namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeOrder order = new CoffeeOrderBuilder()
                .SetSize("Large")
                .AddMilk()
                .AddSugar()
                .AddExtra("Cinnamon")
                .AddExtra("Whipped Cream")
                .Build();

            Console.WriteLine(order);
        }
    }
}
