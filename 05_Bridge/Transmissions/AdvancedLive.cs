﻿using _05_Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge.Transmissions
{
    class AdvancedLive : Live
    {

        public AdvancedLive(IPlatform platform): base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão.");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários ativados na transmissão.");
        }

        public void Record()
        {
            Console.WriteLine("Gravando Transmissão.");
        }

    }
}
