


using System.Xml.Linq;

Animal[] zoo = new Animal[7]
        {
            new Animal() { Name = "Luna", Age = 3, Type = "Cat" },
            new Animal (){ Name = "Rocky", Age = 5, Type = "Dog" },
            new Animal() { Name = "Whiskers", Age = 2, Type = "Rabbit" },
            new Animal() { Name = "Simba", Age = 1, Type = "Lion" },
            new Animal() { Name = "Nemo", Age = 4, Type = "Fish" },
            new Animal() { Name = "Dori", Age = 3, Type = "Fish" },
            new Animal() { Name = "Pescao", Age = 1, Type = "Fish" }
        };
foreach (var z in zoo)
{
    //Console.WriteLine(z.Name);

    //Console.WriteLine(z.Age);

    //Console.WriteLine(z.Type);


}




Console.WriteLine("tests linq");

var zoo1 = from z in zoo
           select z.Type;

var zoo1NoSql= zoo
    .Where(z => z.Name =="Pescao" || z.Type== "Rabbit" || z.Age>1)
    .OrderBy(z => z.Age)
    .Select(z => new {z.Name,z.Age,z.Type,});

var zoo2 = from z in zoo
           where z.Type == "Fish"
           select new { z.Name, z.Age, z.Type };
var zooNoSQL2 = zoo
    .GroupBy(
    z => z.Age,
    z => z.Age, (baseAge, ages)
    => new
    {
        Key = baseAge,
        Count = ages.Count(),
        MinAge = ages.Min(),
        MaxAge = ages.Max(),
    });
foreach (var animal in zooNoSQL2)
{
    
}
//modificar para imprimir lo q sea
foreach (var animal in zoo1NoSql)
{
    Console.WriteLine(animal.Name);

    Console.WriteLine(animal.Age);

    Console.WriteLine(animal.Type);
}


public class Animal
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string Type{ get; set; }

}