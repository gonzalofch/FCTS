using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class UDP: BaseNetworkProperty
    {
        public override void Send()
        {
            Console.WriteLine("Sending UDP... UDP sent");
        }
    }
}
