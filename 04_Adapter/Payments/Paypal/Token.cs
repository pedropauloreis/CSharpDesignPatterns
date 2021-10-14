using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Adapter.Payments.Paypal
{
    class Token
    {
        private readonly string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.6AYq6aSpyhDsttD_npr-0gLMbfwbd9xBf-0AjFPSS0A";

        public string GetToken()
        {
            return token;
        }
    }
}
