using System.Net.NetworkInformation;
using System.Text;
using Pinger;

/*Ping pinger = new Ping();
PingOptions opciones = new PingOptions();

opciones.DontFragment = true;

string data = "transformar a ascii";
byte[] buffer =Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";
PingReply respuesta = pinger.Send(address, timeout, buffer, opciones);
if (respuesta.Status == IPStatus.Success)
{
    Console.WriteLine("Ping Hecho correctamente: {0}",respuesta.Status.ToString());
}
else
{
    Console.WriteLine("PING FALLADO");
}*/
internal class Program
{
    private static void Main(string[] args)
    {
        PingService servicioPinger = new PingService();
        servicioPinger.SendPing();
        //recoger en variable (video)

        //Abstract Class
        PingIPV4 pingIPV4 = new PingIPV4();
        pingIPV4.Iniciar();
        PingIPV6 pingIPV6 = new PingIPV6();
        pingIPV6.Iniciar();


        //INHERITNACE 
        TCP tcp = new TCP();
        UDP udp = new UDP();
        PingCreado ping = new PingCreado();
        tcp.Send();
        udp.Send();
        ping.Send();
        //Polimorfismo
        //instanciar un objeto por medio de una clase base que usa como plantilla
        //Animal perro = new Perro();
        Tortuga tortugon = new Tortuga();
        Animal tortuga = new Tortuga();

        //TestData dataClass = new TestData();
        //int add1 = dataClass.Add(1, 2);
        //int add2 = dataClass.Add(2,6,2);
        ////int add3 = dataClass.Add(2, 6, 2,12);
        // public class TestData
        //{
        //    public int Add(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }
        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }
        //}



        //VARABLES PASADAS POR REFERENCIA y POR VALOR
        //POR VALOR - LAS VARIABLES FUERA DE UN METODO NO VAN A CAMBIAR
        int num1 = 44;
        int num2 = 66;
        Console.WriteLine(num1 + " " + num2);
        Cuadrado(num1, num2);
        Console.WriteLine(num1 + " " + num2);//son los mismos valores

        void Cuadrado(int a, int b)
        {
            a = a * a;
            b = b * b;
        }

        //POR REFERENCIA, CLASE PERSONA
        Console.WriteLine("PERSONA POR REFERENCIA");
        Persona p1 = new Persona();
        Persona p2 = new Persona();
        p1.Edad = 45;
        p2.Edad = 1;
        Console.WriteLine(p1.Edad + " " + p2.Edad);
        CuadradoPersona(p1, p2);
        Console.WriteLine(p1.Edad + " " + p2.Edad);// el valor cambia
        Console.WriteLine(p2);
        void CuadradoPersona(Persona a, Persona b)
        {
            a.Edad = a.Edad * a.Edad;
            b.Edad = b.Edad * b.Edad;
            Console.WriteLine(a.Edad + " " + b.Edad);
        }


        //NULL CONDITIONAL AND COALESCING Ops

        void Imprimir(int ? num )
            { Console.WriteLine(num ); }
        Imprimir(5);
        Imprimir(null);
        Imprimir(8);

        //CONSTRUCTOR ctor
        Pokemon pikachu = new Pokemon("Pikachu", "Electrico");
        Console.WriteLine(pikachu.NombrePok);
        Console.WriteLine(pikachu.TipoPoke);


    }
}

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("Sonido de animal genérico");
    }

}
 class Tortuga : Animal
{
    public override void animalSound()
    {
        Console.WriteLine(" Sonido de tortuga");
    }
}

class Persona
{
    public int Edad { get; set; }
}