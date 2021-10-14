using _06_ChainOfResponsability.Middlewares;
using _06_ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ChainOfResponsability
{
    class Program
    {
        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@master.com.br", "123456");
            server.RegisterUser("user@master.com.br", "654321");

            Middleware checkusermiddleware = new CheckUserMiddleware(server);
            CheckPermissionsMiddleware checkpermissionsmiddleware = new CheckPermissionsMiddleware();
            CheckWeakPassword checkweakpassword = new CheckWeakPassword();

            checkusermiddleware.LinkWith(checkpermissionsmiddleware);
            checkpermissionsmiddleware.LinkWith(checkweakpassword);

            server.SetMiddleware(checkusermiddleware);

            
        }

        private static Server server;
        static void Main(string[] args)
        {
            Init();
            Boolean done = false;

            do
            {
                Console.Write("Digite o seu email: ");
                string email = Console.ReadLine();

                Console.Write("Digite o sua senha: ");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);

            Console.ReadKey();
        }
    }
}
