namespace AbstractFactory
{
    public class CoffeeKitFactory : IBeverageFactory
    {
        public IBeverage CreateBeverage() => new Coffee();
        public ICondiment CreateCondiment() => new Sugar();
    }
}
