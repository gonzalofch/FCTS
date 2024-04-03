using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class TCP: BaseNetworkProperty

    {
        public override void Send()
        {
            Console.WriteLine("Sending TCP... TCP sent");
        }
    }
}
