namespace Bridge
{
    public class DripBrewer : IBrewer
    {
        public void Brew()
        {
            Console.WriteLine("Brewing coffee using a drip brewer.");
        }
    }
}
