using _01_FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
