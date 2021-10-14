using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Platforms
{
    class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtuve: Configurando Servidor RMTP");
        }
    }
}
