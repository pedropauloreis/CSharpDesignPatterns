using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Payonner
{
    interface IPayonner
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
