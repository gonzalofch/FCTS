using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class PingService
    {
        public string Data { get; set; }
        public byte []  Buffer { get; set; }
        public int Timeout { get; set; }
        public string Address { get; set; }
        public Ping pingSender { get; set; }
        public PingOptions pingOptions { get; set; }
        public PingService()
        {
            Timeout = 130;
            Address = "4.2.2.2";
            Buffer = Encoding.ASCII.GetBytes("Learn Tooooo code");
            pingOptions = new PingOptions();
            pingSender = new Ping();
            pingOptions.DontFragment = true;
    }
        public bool SendPing()
        {
            PingReply reply = pingSender.Send(Address,Timeout,Buffer,pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address {0}",reply.Address.ToString() );
                Console.WriteLine("RoundTrip time {0}", reply.RoundtripTime);
                Console.WriteLine("T T L{0}", reply.Options.Ttl);
                Console.WriteLine("Don't Fragment {0}", reply.Options.DontFragment);
                Console.WriteLine("Buff size{0}", reply.Buffer.Length);
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
    

}
