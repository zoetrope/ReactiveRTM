using ReactiveRTM.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtcLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var manager = new RtcManager(args))
            {
                manager.Run();
            }
        }
    }
}
