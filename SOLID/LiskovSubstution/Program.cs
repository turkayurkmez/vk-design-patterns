// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
/*
 * Birbirlerinden miras alan iki sınıf; herhangi bir davranışsal değişiklik göstermeden birbirlerinin yerine kullanılabilir olmalıdır. Ancak bu koşul sağlanıyorsa miras alabilir.
 * 
 */

var rect = new Geometry().CreateRectangle(5,10);
//rect.Width = 8;
//rect.Height = 10;
Console.WriteLine(rect.GetArea());