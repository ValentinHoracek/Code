namespace Bridge
{
    public class EspressoBrewer : IBrewer
    {
        public void Brew()
        {
            Console.WriteLine("Brewing coffee using an espresso brewer.");
        }
    }
}
