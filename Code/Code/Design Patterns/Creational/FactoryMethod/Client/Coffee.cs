namespace FactoryMethod.Client
{
    public class Coffee : IDrink
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing coffee...");
        }
    }
}
