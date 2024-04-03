using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class Pokemon
    {
        public string NombrePok { get; set; }
        public string TipoPoke { get; set; }

        public Pokemon(string nombre, string tipo)
        {
            this.NombrePok = nombre;
            this.TipoPoke = tipo;
        }
    }
}
