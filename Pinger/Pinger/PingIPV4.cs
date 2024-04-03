using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class PingIPV4:BasePing
    {
        public bool EnviarPing()
        {
            return true;
        }
        public override bool Iniciar()
        {
            Console.WriteLine("Override IPV4");
            return true;

        }
    }
}
