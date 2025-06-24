namespace Composite
{
    public class Drink : IDrinkComponent
    {
        private readonly string _name;
        private readonly List<IDrinkComponent> _components = new();

        public Drink(string name)
        {
            _name = name;
        }

        public void AddComponent(IDrinkComponent component)
        {
            _components.Add(component);
        }

        public void Display()
        {
            Console.WriteLine($"{_name} consists of:");
            foreach (var component in _components)
            {
                component.Display();
            }
        }
    }
}
