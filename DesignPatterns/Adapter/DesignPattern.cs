using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /*
     *  Üçüncü parti bir bileşen geriye XML döndürüyor.
     *  Ancak bizim JSON (veya object) türünde veriye ihtiyacımız var
     *  
     */

    public class Product
    {

    }

    //Client Interface: istemcinin doğrudan kullanabileceği nesne
    public interface IDataTransfer
    {
        public List<Product> GetProducts();
    }

    //Önceden yazılmış harici bileşende erişmek istediğiniz fonksiyonu barındıran kaynak:
    public class XMLSource : IDataTransfer
    {
        public List<Product> GetProducts()
        {
            Console.WriteLine("XML'den veriyi aldı");
            return new List<Product>();
        }
    }



    //3. Adaptör: İhtiyacınız olan türe dönüştürecek nesne

    public class JsonAdapter : IDataTransfer
    {
        private readonly XMLSource source;

        public JsonAdapter(XMLSource source)
        {
            this.source = source;
        }

        public List<Product> GetProducts()
        {
            return source.GetProducts();
        }
    }


}
