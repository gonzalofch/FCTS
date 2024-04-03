
using System.Text;
using System.Threading.Channels;
using CTutorial;

string cadena = "aaa";
char vocal = 'a';
int utf = vocal;
Console.WriteLine(utf);
Console.WriteLine(cadena);
string dinami = "cambia1";
Console.WriteLine(dinami);
dinami = "cambio2";
Console.WriteLine(dinami);
float flottt = 0.4f;
double doubbt = 0.333333;
decimal deccm = .434344m;
decimal deccma = 0.43422344m;

int enterr = 5;

enterr += enterr * 2;
Console.WriteLine(enterr);


//CAST 

int decimalcastt = (int)deccma;
Console.WriteLine($"DECIMAL CASTEADO: {decimalcastt}");


string texto = "5555555"; //cambiar a letras para error
int resultado = 0;
if (int.TryParse(texto, out resultado))
{
	Console.WriteLine("PIOLA " + resultado);
}
else
{
	Console.WriteLine("NO CAST ");
}
//STACK & HEAP 
StackHeapEjemplo Stacccck = new StackHeapEjemplo();
Console.WriteLine(Stacccck.AddFive(enterr));
//ARRAYS (colecciones de sets de valores) declaracion ->
int longitud = 5;
int[] arr = new int[longitud];//fix dando longitud
string[] arra = new string[longitud];
int[] dinamicarr = new int[] { 1, 2, 3, 4, 5 };//dynamic no especifico
dinamicarr[0] = longitud;

int numb = 10;
for (int i = 0; i < arr.Length; i++)
{
	arr[i] = numb;
	numb += 10;
}
foreach (var item in arr)
{
	Console.WriteLine(item);
}
Console.WriteLine("DINAMICO");
foreach (var item in dinamicarr)
{
	Console.WriteLine(item);
}
Console.WriteLine(arr.Average());
//revisar los metodos Linq  yendo a la definicionde los mismos
//acceder como en otros lenguajes arr[i] = loquesea;

//STRINGS
char[] testLowLvl = new[] { 'a', 'b', 'c', 'd', 'e' };
string testtt = "Test";
String testte = "Test"; //tiene mas metodos pero son lo mismo
string menssaje1;
string menssaje2 = null;//string puede ser null
						// int numeronulo = null; //NO PUEDEN SER NULOS (VALUE TYPES)


//Literal & Verbatim

string rutaArchivo = "c:\\ProgramFiles";
string rutaArchivoVerbatim = @"c:\\ProgramFiles";


//string INMUTABILITY NO PUEDE REEMPLAZAR EL MISMO ESPACIO EN MEMORIA
string s1 = "Hello";
string s2 = s1;
s1 += "World";
Console.WriteLine(s2);//NO IMPRIME WORLD
Console.WriteLine(s1);

//STRING INTERPOLLATION  Composite Formatting
string nombre = " gonzalo ";
string apellido = " flores ";
//Con el $$$$$$
Console.WriteLine($"nombre {nombre} completo  {apellido}");
Console.WriteLine("nombre {0} completo  {1}", nombre, apellido);

//String Build 
//
var testSB = new StringBuilder(nombre);
testSB.Append(apellido);
Console.WriteLine(testSB);


//VIDEO 6
//VIDEO 8 LIST
List<Part> list = new List<Part>();
list.Add(new Part { PartName="Snake",PartId=1});
list.Add(new Part { PartName = "Ocelot", PartId = 2 });
list.Add(new Part { PartName = "Raiden", PartId = 3 });
list.Add(new Part { PartName = "Sam", PartId = 5 });
list.Add(new Part { PartName = "Sorrow", PartId = 6 });
foreach (Part part in list)
{
    Console.WriteLine(part.PartName.ToString());

    Console.WriteLine(part.PartId.ToString());
}
//Operadores ternarios
var afirmacion = 5 > 22? 15:20 ;
Console.WriteLine(afirmacion);

//ENUM SWITCH
State state = State.Active;

switch (state)
{
	case State.Active:
        Console.WriteLine("ACTIVO");
        break;
	case State.Inactive:
        Console.WriteLine("INACTIVO");
        break;
	default:
		break;
}
//CLASS Perro syntax
Perro perro = new Perro();
perro.ladrar();
Console.WriteLine(perro.nombrePerro);//etcetc

//ABSTRACT CLASS SuperList
Perro perro2 = new Perro();
perro2.ladrar();
perro2.caminarMucho();
perro2.caminarAlParque();
