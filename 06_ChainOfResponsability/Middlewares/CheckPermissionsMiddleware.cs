using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ChainOfResponsability.Middlewares
{
    class CheckPermissionsMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(email.Equals("master@master.com.br"))
            {
                Console.WriteLine("Seja bem-vindo administrador");
            }
            else
            {
                Console.WriteLine($"Seja bem-vindo usuário {email}");
            }

            

            return CheckNext(email, password);
        }
    }
}
