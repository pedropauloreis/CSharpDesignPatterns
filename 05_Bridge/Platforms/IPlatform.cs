using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Platforms
{
    interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
