namespace Iterator
{
    internal class CoffeeBeanIterator : IIterator<CoffeeBean>
    {
        private readonly List<CoffeeBean> beans;
        private int position = 0;

        public CoffeeBeanIterator(List<CoffeeBean> beans) => this.beans = beans;

        public bool HasNext() => position < beans.Count;

        public CoffeeBean Next() => beans[position++];
    }
}