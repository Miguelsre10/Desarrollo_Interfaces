using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal class Car : IVehicle
    {
        public void Star()
        {
            Console.WriteLine("Coche arrancando");
        }

        public void Stop()
        {
            Console.WriteLine("Coche frenando");
        }

        public void Accelerate()
        {
            Console.WriteLine("Coche acelerando");
        }

    }
}
