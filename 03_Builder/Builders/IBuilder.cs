using _03_Builder.Components;
using _03_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetVehicleType(VehicleType vehicleType);
        void SetTransmission(TransmissionType transmissionType);
        void setEngine(Engine engine);
        void setSeats(int seats);

        void setAirbag(Airbag airbag);
    }
}
