using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CoffeeMachine
    {
        public void OrderEspresso() => Console.WriteLine("☕ Espresso ordere!");
        public void CancelEspresso() => Console.WriteLine("❌ Espresso canceled.");

        public void OrderLatte() => Console.WriteLine("🥛 Latte ordere!");
        public void CancelLatte() => Console.WriteLine("❌ Latte canceled.");
    }
}
