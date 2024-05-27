using ClassAndObject;

Console.WriteLine("Test");

Product hat = new Product();
Product keyboard = new Product();

hat.Name = "Indiana Jones Şapkası";

Product sunGlass = hat;
sunGlass.Name = "Robocop sunglasses";
Console.WriteLine(hat.Name);
//sunglass Heap adresi ile -> hat adresi aynı


