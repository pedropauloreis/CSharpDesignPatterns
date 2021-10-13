using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_FactoryMethod.Vehicles;

namespace _01_FactoryMethod.Factories
{
    abstract class Transport
    {
        public void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.startRoute();
        }
        protected abstract IVehicle CreateTransport();
    }
}
