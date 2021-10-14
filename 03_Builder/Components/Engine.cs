using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Components
{
    class Engine
    {
        private int power;

        public Engine(int power)
        {
            this.power = power;
        }

        public int Power
        {
            get => power;
            set => power = value;
        }


    }
}
