using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car1 = new Car(); //solo los metodos de la interfaz
            Car car2 = new Car();
            IVehicle moto = new Motorbike();

            car1.Star();
            car2.Accelerate();
            
            moto.Stop();
        }
    }
}
