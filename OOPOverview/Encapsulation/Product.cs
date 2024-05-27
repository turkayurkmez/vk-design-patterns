using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new Exception("Fiyat negatif olamaz");

            }

            this.price = value;
        }

        public decimal GetPrice() { return price; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException();
                }
                name = value;
            }
        }

        public double Rating { get; set; }

        public decimal DiscountedPrice { get;  }
        public Product()
        {
            DiscountedPrice = price * 0.95m;
        }

        public int StockCount { get; private set; }
        public void UpdateStock()
        {
            this.StockCount += 100;
        }
    }
}
