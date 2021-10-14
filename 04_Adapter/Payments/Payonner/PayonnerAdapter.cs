using _04_Adapter.Payments.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Payonner
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payonner.ReceivePayment();
        }

    }
}
