using App.Console;

Console.WriteLine("My name is Thai");
Console.WriteLine("Hello, World!");

var bow = new Bow();
var gun = new Gun();

var thai = new Person(gun)
{
    Name = "Thai",
    Age = 21
};

Console.WriteLine(thai.Name);
Console.WriteLine(thai.Age);