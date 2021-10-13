using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Landvehicles
{
    class Patinete : ILandVehicle
    {
        public void getCargo()
        {
            Console.WriteLine("Passageiro logado no patinete");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Iniciando viagem com patinete");
        }
    }
}
