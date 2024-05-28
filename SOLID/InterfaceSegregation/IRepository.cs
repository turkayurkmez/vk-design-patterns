using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Product
    {

    }

    public class Order
    {
        
    }
    public interface IRepository<T> 
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

       
    }

    public interface ISearchable<T>
    {
        IEnumerable<T> SearchByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> GetAll()
        {
            return new List<Order>();   
        }

        public Order GetById(int id)
        {
            return new Order();
        }

       
    }

    public class EntitySearcher<T>
    {
        public void Search(ISearchable<T> searchableRepository,string name )
        {
             searchableRepository.SearchByName(name);
        }
    }
}
/*
 * Bir sınıf, bir interface'i implemente ettiğinde; tüm fonksiyonları kullanmak zorundadır.
 * Sınıf, eğer implemente ettiği bir interface'in fonksiyonunu kullanmıyorsa; o fonksiyon o interface içinde bulunmamalıdır.
 */