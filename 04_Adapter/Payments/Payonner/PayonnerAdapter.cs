using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Payonner
{
    class PayonnerAdapter : IPaymentAdapter
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
        }

        public void Receive()
        {
            this.payonner.ReceivePayment();
        }

        public void Send()
        {
            this.payonner.SendPayment();
        }
    }
}
