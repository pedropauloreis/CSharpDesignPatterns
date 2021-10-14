using _03_Builder.Builders;
using _03_Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Directors
{
    class  Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetTransmission(TransmissionType.AUTOMATIC);
            builder.setEngine(new Engine(2000));
            builder.setSeats(5);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetTransmission(TransmissionType.MANUAL);
            builder.setEngine(new Engine(4000));
            builder.setSeats(2);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetTransmission(TransmissionType.AUTOMATIC_SEQUENTIAL);
            builder.setEngine(new Engine(2500));
            builder.setSeats(7);
            builder.setAirbag(new Airbag(AirbagQualityType.CLASSE_A));
        }
    }
}
