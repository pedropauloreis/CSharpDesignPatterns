using _04_Adapter.Payments;
using _04_Adapter.Payments.Paypal;
using _04_Adapter.Payments.Payonner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {



            IPaymentAdapter payment = null;
            string pagamento = "Payonner";

            switch(pagamento)
            {
                case "Paypal":
                    PayPal paypal = new PayPal();
                    payment = new PayPalAdapter(paypal);
                    break;
                case "Payonner":
                    Payonner payonner = new Payonner();
                    payment = new PayonnerAdapter(payonner);
                    break;
            }
            
            if(payment != null)
            {
                payment.Send();
                payment.Receive();

            }


            Console.ReadKey();
        }
    }
}
