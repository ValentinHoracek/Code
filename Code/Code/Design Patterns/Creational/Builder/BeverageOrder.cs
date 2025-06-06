namespace Builder
{
    public class BeverageOrder
    {
        public string? Size { get; set; }
        public IFlavor? Flavor { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public List<string> Extras { get; set; } = new();

        public override string ToString()
        {
            string extras = Extras.Count > 0 ? $" with {string.Join(", ", Extras)}" : string.Empty;
            return $"{Size} {Flavor?.GetType().Name}{(HasMilk ? " with milk" : string.Empty)}{(HasSugar ? " with sugar" : string.Empty)}{extras}";
        }
    }
}
