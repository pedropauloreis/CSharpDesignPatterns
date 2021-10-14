using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Paypal
{
    class PayPalAdapter : IPaymentAdapter
    {

        private PayPal paypal;

        public PayPalAdapter(PayPal paypal)
        {
            this.paypal = paypal;
        }
        public void Receive()
        {
            this.paypal.PayPalReceive();
        }

        public void Send()
        {
            this.paypal.PayPalPayment();
        }
    }
}
