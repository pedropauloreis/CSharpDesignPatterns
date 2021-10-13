using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryMethod.Vehicles
{
    class Motorcycle : IVehicle
    {
        public void getCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Iniciando a Entrega.");
        }
    }
}
