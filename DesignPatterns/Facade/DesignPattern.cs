using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	/*
	 * Çok fazla nesnenin kullanıldığı karmaşık işleriniz var. İstiyorsunuz ki basit bir fonksiyon, tüm bu işleri yapsın ve yönetsin.
	 * 
	 * Çözüm:
	 * Karmaşık işleri arkaplanda çalıştıran bir "ön cephe" oluşturun
	 */

	public class Customer
	{
        public string Name { get; set; }
    }

	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }

	public class Order
	{
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }


    }

	public class OrderItem
	{
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class ShoppingItem 
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderService //Facade
    { 
    
        public void CreateOrder(string customerName, List<ShoppingItem> products)
        {
            Customer customer = new Customer { Name = customerName };
            Order order = new Order { Id = 16 , OrderDate = DateTime.Now};
            order.Customer = customer;

            order.OrderItems = new List<OrderItem>();

            products.ForEach(product =>
            {
                var orderItem = new OrderItem { OrderId =order.Id, ProductId = product.ProductId, Quantity = product.Quantity };
                order.OrderItems.Add(orderItem);

                Console.WriteLine($"{customer.Name} müşterisi, {order.OrderDate} tarihinde {product.ProductId} id'li üründen, {product.Quantity} adet sipariş verdi");
                Console.WriteLine($"Ürünün stoğundan {product.Quantity} adet düşüldü");
            });
        }
    } 

}
