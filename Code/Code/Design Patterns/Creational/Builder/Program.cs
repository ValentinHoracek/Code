namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BeverageDirector director = new();

            BeverageOrder coffeeOrder = director.BuildCofee();
            BeverageOrder teaOrder = director.BuildTea();

            Console.WriteLine(coffeeOrder);
            Console.WriteLine(teaOrder);
        }
    }
}
