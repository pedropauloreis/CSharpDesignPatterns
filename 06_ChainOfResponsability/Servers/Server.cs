﻿using _06_ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean LogIn(string email, string password)
        {
            if (middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso.");
                Console.WriteLine("Seja Bem-vindo!");
                return true;
            }
            else
                return false;
            
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassward(string email, string password)
        {
            string value = "";
            users.TryGetValue(email, out value);

            return password== value;
        }
    }
}
