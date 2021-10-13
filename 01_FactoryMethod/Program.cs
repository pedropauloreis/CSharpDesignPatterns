using _01_FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null; 
            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();

            } else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();

            } else if (args.Length > 0 && args[0] == "--eats")
            {
                transport = new BikeTransport();

            } else
            {
                Console.WriteLine("Especifique o meio de transporte. --uber / --log ");

            }

            if(transport!= null)
            {
                transport.StartTransport();

            }

            Console.ReadKey();
        }
    }
}
