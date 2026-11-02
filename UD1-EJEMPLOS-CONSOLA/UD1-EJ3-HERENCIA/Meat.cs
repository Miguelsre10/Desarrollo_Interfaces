using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Meat : Ingredient
    {
        public String Type { get; set; }
        public Meat(string name, double amount, String type) : base(name, amount)
        {
            Type = type;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparando {Amount}g de {Name} de {Type}");
        }
    }
}
