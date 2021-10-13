using _02_AbstractFactory.Vehicles.Aircrafts;
using _02_AbstractFactory.Vehicles.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Motorcycle();
        }
    }
}
