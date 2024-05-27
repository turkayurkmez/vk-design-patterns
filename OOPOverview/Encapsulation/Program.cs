using Encapsulation;

Product product = new Product();


decimal value = -5;
if (value<0)
{
    //exception fırlat
}

//product.Price = value;
product.SetPrice(-16);
Console.WriteLine(product.Rating);
product.Rating = 4.6;


