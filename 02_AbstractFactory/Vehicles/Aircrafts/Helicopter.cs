using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, vento sudeste, ok para Helicóptero.");
        }

        public void getCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando Helices.");
        }

        public void startRoute()
        {
            CheckWind();
            getCargo();
            Console.WriteLine("Iniciando decolagem do Helicóptero.");
        }
    }
}
