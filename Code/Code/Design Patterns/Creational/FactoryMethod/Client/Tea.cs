namespace FactoryMethod.Client
{
    public class Tea : IDrink
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing tea...");
        }
    }
}
