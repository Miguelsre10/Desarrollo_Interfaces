using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Vegetable : Ingredient
    {
        public Vegetable(string name, double amount) : base(name, amount)
        {
            Name = name;
            Amount = amount;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparando {Amount}g de {Name} ");
        }
    }
}
