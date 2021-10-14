using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Payonner
{
    class Payonner : IPayonner
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento pagamento com Payonner.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento pagamento com Payonner.");

        }
    }
}
