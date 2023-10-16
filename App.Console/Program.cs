using App.Console;
using System.Text.Json;

Console.WriteLine("My name is Thai");
Console.WriteLine("Hello, World!");

var bow = new Bow();
var gun = new Gun();

List<string> list = new List<string>();
List<int> list2 = new List<int>();

var thai = new Person<int>(gun)
{
    Name = "Thai",
    Age = 21,
    Height = 169
};

var nhan = new Person<double>(gun)
{
    Name = "Thai",
    Age = 21,
    Height = 1.79
};

var result = JsonSerializer.Serialize(thai);

//var str = @"{""Name"":""Nhan"",""Age"":21,""Weapon"":{""Damge"":0}}";
//var nhan = JsonSerializer.Deserialize<Person>(str);

Console.WriteLine(nhan.Name);
Console.WriteLine(nhan.Age);


//Console.WriteLine(result);

//Console.WriteLine(thai.Name);
//Console.WriteLine(thai.Age);