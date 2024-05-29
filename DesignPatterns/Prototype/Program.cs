// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");

/*
 * Oluşturulması çok zaman alan bir nesneniz var. Ve bu nesneden, yüzlerce üretmeniz (bellekte 300 adet olması) gerek. Bu zaman kaybını en aza nasıl indiririz? 
 */

Chair a1 = new Chair();
Console.WriteLine($" reference code:  {a1.GetHashCode()}, değer: {a1}");
a1.Cinema.Movie =   "Jurassic Park";

Chair a2 =(Chair) a1.Clone();
a2.ChairLetter = "A";
a2.ChairNo = 2;

a2.Cinema.Movie = "Jurassic Park";
Console.WriteLine($" reference code:  {a2.GetHashCode()}, değer: {a2}");




Chair a3 =(Chair) a1.Clone();
a3.ChairLetter = "A";
a3.ChairNo = 3;
Console.WriteLine($" reference code:  {a3.GetHashCode()}, değer: {a3}");

string[] letters = { "A", "B", "C" };

