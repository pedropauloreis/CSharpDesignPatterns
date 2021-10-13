using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void getCargo()
        {
            Console.WriteLine("Pegamos a comida.");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Entregando a comida.");
        }
    }
}
