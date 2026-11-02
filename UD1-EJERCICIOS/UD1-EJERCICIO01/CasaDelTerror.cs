using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO01
{
    internal class CasaDelTerror : Atraccion
    {
        public int NivelDeMiedo {  get; set; }

        public CasaDelTerror(string nombre, double precio, int edadMinima, int alturaMinima, int nivelMiedo) : base(nombre, precio, edadMinima, alturaMinima)
        {
            NivelDeMiedo = nivelMiedo;
        }

        public override bool AdmitirVisitante(int edad, int altura)
        {
            if (edad >= EdadMinima && altura >= AlturaMinima)
            {
                
                Console.WriteLine($"El nivel de miedo es {NivelDeMiedo}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
