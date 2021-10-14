using _05_Bridge.Platforms;
using _05_Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarda iniciando...");
            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarda iniciando...");
            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }
        static void Main(string[] args)
        {
            StartAdvancedLive(new DLive());
            StartLive(new Youtube());
            StartLive(new Facebook());
            StartAdvancedLive(new TwitchTV());

            Console.ReadKey();

        }
    }
}
