using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Vehicles
{
    interface IVehicle
    {
        void startRoute();
        void getCargo();
    }
}
