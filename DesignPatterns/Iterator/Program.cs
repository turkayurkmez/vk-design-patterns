// See https://aka.ms/new-console-template for more information
using Iterator;
using System.Collections;

Console.WriteLine("Hello, World!");


var letters = new List<string>() { "A","B","C","D"};
IteratorClass iterator = new IteratorClass(letters);
Console.WriteLine(iterator.Current); 
if (iterator.MoveNext())
{
    Console.WriteLine(iterator.Current);

}

Console.WriteLine($"First: {  iterator.First()}");
Console.WriteLine($"Last: {iterator.Last()}");