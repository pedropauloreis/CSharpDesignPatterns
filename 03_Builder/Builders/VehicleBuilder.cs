using _03_Builder.Components;
using _03_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle resultVehicle = this.vehicle;
            Reset();
            return resultVehicle;
        }

        public void Reset()
        {
            this.vehicle = new Vehicle();
        }

        public void setAirbag(Airbag airbag)
        {
            this.vehicle.Airbag = airbag;
        }

        public void setEngine(Engine engine)
        {
            this.vehicle.Engine = engine;
        }

        public void setSeats(int seats)
        {
            this.vehicle.Seats = seats;
        }

        public void SetTransmission(TransmissionType transmissionType)
        {
            this.vehicle.TransmissionType = transmissionType;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            this.vehicle.VehicleType = vehicleType;
        }

        


    }
}
