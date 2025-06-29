namespace Iterator
{
    public class CoffeeBeanCollection :ICoffeeBeanCollection
    {
        private List<CoffeeBean> beans = new();

        public void Add(CoffeeBean bean) => beans.Add(bean);

        public IIterator<CoffeeBean> CreateIterator() => new CoffeeBeanIterator(beans);
    }
}
