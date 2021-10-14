using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ChainOfResponsability.Middlewares
{
    class CheckWeakPassword : Middleware
    {


        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha fraca identificada, troque sua senha.");
            }

            return CheckNext(email, password);
        }
    }
}
