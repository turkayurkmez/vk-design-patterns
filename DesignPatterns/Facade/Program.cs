// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
OrderService orderService = new OrderService();

var shopping = new List<ShoppingItem>
{
    new(){ ProductId=1, Quantity=5},
    new(){ ProductId=8, Quantity=15},
    new(){ ProductId=9, Quantity=2},


};

orderService.CreateOrder("Türkay", shopping);