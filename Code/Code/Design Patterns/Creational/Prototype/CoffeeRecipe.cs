namespace Prototype
{
    public class CoffeeRecipe : ICoffeeRecipe
    {
        public string? Name { get; set; }
        public int WaterMl { get; set; }
        public int CoffeeGrams { get; set; }
        public bool HasMilk { get; set; }

        public ICoffeeRecipe Clone()
        {
            return (ICoffeeRecipe)MemberwiseClone();
        }
        public void Print()
        {
            System.Console.WriteLine($"Recipe: {Name}, Water: {WaterMl}ml, Coffee: {CoffeeGrams}g, Milk: {HasMilk}");
        }
    }
}
