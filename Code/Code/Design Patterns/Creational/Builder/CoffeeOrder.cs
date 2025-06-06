namespace Builder
{
    public class CoffeeOrder
    {
        public string? Size { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public List<string> Extras { get; set; } = new();

        override public string ToString()
        {
            string extras = Extras.Count > 0 ? $" with {string.Join(", ", Extras)}" : string.Empty;
            return $"{Size} coffee{(HasMilk ? " with milk" : string.Empty)}{(HasSugar ? " with sugar" : string.Empty)}{extras}";
        }
    }
}
