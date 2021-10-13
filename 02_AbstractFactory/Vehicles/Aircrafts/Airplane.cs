using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25Km/h, ventos ok!");
        }

        public void getCargo()
        {
            Console.WriteLine("Passageiros à bordo, vôo autorizado.");
        }

        public void startRoute()
        {
            CheckWind();
            getCargo();
            Console.WriteLine("Iniciando decolagem.");
        }
    }
}
