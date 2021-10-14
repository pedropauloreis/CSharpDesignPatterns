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



            IPayPalPayment payment = null;
            string pagamento = "Paypal";

            switch(pagamento)
            {
                case "Paypal":
                    payment = new PayPal();
                    break;
                case "Payonner":
                    Payonner payonner = new Payonner();
                    payment = new PayonnerAdapter(payonner);
                    break;
            }
            
            if(payment != null)
            {
                payment.PayPalPayment();
                payment.PayPalReceive();

            }


            Console.ReadKey();
        }
    }
}
