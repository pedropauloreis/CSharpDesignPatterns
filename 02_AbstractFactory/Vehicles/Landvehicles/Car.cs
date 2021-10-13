using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Landvehicles
{
    class Car : ILandVehicle
    {
        public void getCargo()
        {
            Console.WriteLine("Pegamos os passageiros.");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
