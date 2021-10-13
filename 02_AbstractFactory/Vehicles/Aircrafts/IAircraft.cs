using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles.Aircrafts
{
    interface IAircraft : IVehicle
    {
        void CheckWind();
    }
}
