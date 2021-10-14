using _03_Builder.Builders;
using _03_Builder.Directors;
using _03_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criado um veículo do tipo {sedan.VehicleType}");


            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criado um veículo do tipo {truck.VehicleType}");


            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();
            Console.WriteLine($"Criado um veículo do tipo {suv.VehicleType} com Airbag ${suv.Airbag.AirbagQualityType}");

            Console.ReadKey();
        }
    }
}
