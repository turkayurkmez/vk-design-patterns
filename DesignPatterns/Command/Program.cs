// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");

/*
 *  Bir isteği çeşitli araçlar aracılığıyla ve farklı türlerde alıyorsunuz ve başka bir nesnenin işlemesini bekliyorsunuz. Aynı zamanda bu istek geri de alınabilir olmalı. Bu istekleri bir arada tutma ve çalışma sırasını (kuyruk) vesaire nasıl belirlersiniz?
 */

DatabaseCommandReceiver receiver = new DatabaseCommandReceiver();
DiscountProductCommand discountProductCommand = new DiscountProductCommand(receiver) {  Id=18, DiscountRate=0.25m};
RaiseProductCommand raiseProductCommand = new RaiseProductCommand(receiver) {  ProductId = 26, RaisedRate = 0.50m};

CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.Add(discountProductCommand);
commandInvoker.Add(raiseProductCommand);

commandInvoker.ExecuteCommands();

void ChangePrice(double price)
{
	if (price<0)
	{
		throw new ArgumentOutOfRangeException("Değer negatif olamaz");
	}
	Price = price;
}