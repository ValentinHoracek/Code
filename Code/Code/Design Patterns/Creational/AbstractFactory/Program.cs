namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IBeverageFactory teaFactory = new TeaKitFactory();
            IBeverageFactory coffeeFactory = new CoffeeKitFactory();

            BeverageOrder teaOrder = new(teaFactory);
            BeverageOrder coffeeOrder = new(coffeeFactory);

            teaOrder.Serve();
            coffeeOrder.Serve();
        }
    }
}
