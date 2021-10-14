using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Platforms
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando Servidor RMTP");
        }
    }
}
