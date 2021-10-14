using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments
{
    interface IPaymentAdapter
    {
        void Send();
        void Receive();
    }
}
