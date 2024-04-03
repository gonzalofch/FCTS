using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinger
{
    public class PingIPV6 : BasePing
    {//EJERCICIO PARA NO DUPLICAR CODIGO

        public override bool Iniciar()
        {
            Console.WriteLine("Override IPV6");
            return true;
        }
        public bool EnviarPing()
        {
            return true;
        }
        //Diferenciar, para evitar duplicar, extraer de una clase base BasePing

    }
}