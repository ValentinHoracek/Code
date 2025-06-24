using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Leaf
    public class Ingredient : IDrinkComponent
    {
        private readonly string _name;

        public Ingredient(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine($"- {_name}");
        }
    }
}
