// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var x = "Adrian123";
var y = "adrian123";


Console.WriteLine(x == y);
Console.WriteLine(x.Equals(y));
Console.WriteLine(string.Equals(x,y, StringComparison.OrdinalIgnoreCase));
