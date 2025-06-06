namespace AbstractFactory
{
    public interface IBeverageFactory
    {
        IBeverage CreateBeverage();
        ICondiment CreateCondiment();
    }
}
