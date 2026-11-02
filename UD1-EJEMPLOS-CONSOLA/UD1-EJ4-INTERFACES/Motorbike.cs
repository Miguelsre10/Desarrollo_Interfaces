using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal class Motorbike: IVehicle
    {
        public void Star()
        {
            Console.WriteLine("Moto arrancando");
        }

        public void Stop()
        {
            Console.WriteLine("Moto frenando");
        }
    }
}
