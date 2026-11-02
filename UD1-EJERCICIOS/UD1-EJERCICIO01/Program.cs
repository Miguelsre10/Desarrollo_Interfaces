using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasaDelTerror ct = new CasaDelTerror("ct", 5.5, 12, 100, 7);
            int edad;
            int altura;
            do
            {
                Console.WriteLine("Introduce la edad del visitante");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la altura del visitante (cm)");
                altura = int.Parse(Console.ReadLine());
                if (ct.AdmitirVisitante(edad, altura))
                {
                    Console.WriteLine($"El visitante puede disfrutar de {ct.Nombre}");
                }
                else
                {
                    Console.WriteLine($"El visitante no cumple con los requisitos de la atraccion");
                }

            } while (edad != 0 || altura != 0);
        }
    }
}
