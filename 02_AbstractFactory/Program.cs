using _02_AbstractFactory.App;
using _02_AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            ITransportFactory transportFactory;
            string company = "Lime";

            switch(company)
            {
                case "Uber":
                    transportFactory = new UberTransport();
                    break;
                case "99":
                    transportFactory = new NineNineTransport();
                    break;
                case "Lime":
                    transportFactory = new LimeTransport();
                    break;
                default:
                    transportFactory = new UberTransport();
                    break;
            }

            return new Application(transportFactory);

        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadKey();
        }
    }
}
