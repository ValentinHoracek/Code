namespace Iterator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeBeanCollection collection = new();
            collection.Add(new CoffeeBean("Arabica", "Ethiopia"));
            collection.Add(new CoffeeBean("Robusta", "Vietnam"));
            collection.Add(new CoffeeBean("Liberica", "Philippines"));

            IIterator<CoffeeBean> iterator = collection.CreateIterator();

            while (iterator.HasNext())
            {
                CoffeeBean bean = iterator.Next();
                Console.WriteLine($"Coffee Bean: {bean.Name}, Origin: {bean.Origin}");
            }
        }
    }
}
