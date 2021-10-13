using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryMethod.Vehicles
{
    class Car : IVehicle
    {
        public void getCargo()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
