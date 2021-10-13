using _02_AbstractFactory.Factories;
using _02_AbstractFactory.Vehicles.Aircrafts;
using _02_AbstractFactory.Vehicles.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle landvehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            landvehicle = factory.CreateTransportLandVehicle();
        }

        public void StartRoute()
        {
            aircraft.startRoute();
            landvehicle.startRoute();
        }
    }
}
