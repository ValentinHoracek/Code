namespace AbstractFactory
{
    public class TeaKitFactory : IBeverageFactory
    {
        public IBeverage CreateBeverage() => new Tea();
        public ICondiment CreateCondiment() => new Lemon();
    }
}
