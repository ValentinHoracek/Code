namespace Iterator
{
    public interface ICoffeeBeanCollection
    {
        IIterator<CoffeeBean> CreateIterator();
    }
}
