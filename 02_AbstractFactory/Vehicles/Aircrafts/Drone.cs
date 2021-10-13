using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos favoráveis para utilização de drone.");
        }

        public void getCargo()
        {
            Console.WriteLine("Drone Carregado.");
        }

        public void startRoute()
        {
            getCargo();
            Console.WriteLine("Drone decolando.");
        }
    }
}
