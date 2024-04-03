using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTutorial
{
    public class Perro :CapazDeCaminar
    {
        public string nombrePerro { get; set; }
        public int edadPerro { get; set; }
        public bool bueno{ get; set; }
        public void ladrar()
        {
            Console.WriteLine("Ladrar {0}", this.nombrePerro);
        }

        public void caminarAlParque()
        {
            Console.WriteLine("Al Parque");
        }

        public void caminarAlMercado()
        {
            Console.WriteLine("Al Mercado");
        }

        public void caminarMucho()
        {
            Console.WriteLine("Caminar nada más, nada menos");
        }

        public Perro() {
            nombrePerro= "Cabezon";
            edadPerro = 4;
            bueno = true;

        }  
    }
}
