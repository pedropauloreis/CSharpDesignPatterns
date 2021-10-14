using _03_Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;
        private TransmissionType transmissionType;
        private Airbag airbag;
        private Engine engine;
        private int seats;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public TransmissionType TransmissionType
        {
            get => transmissionType;
            set => transmissionType = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Airbag Airbag
        {
            get => airbag;
            set => airbag = value;
        }


    }
}
