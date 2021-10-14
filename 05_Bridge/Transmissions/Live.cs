using _05_Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Transmissions
{
    class Live : ITransmission
    {
        protected IPlatform platform;
        public Live(IPlatform platform)
        {
            this.platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {platform}");
        }

        public void Result()
        {
            Console.WriteLine($"ON AIR na {platform}");
        }
    }
}
