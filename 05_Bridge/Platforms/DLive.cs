using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Platforms
{
    class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissão Iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando Servidor RMTP");
        }
    }
}
