// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");

/*
 *   İstediğiniz:
 *   
 *      Bir nesne oluşturacaksınız ve bu [nesne] oluştuğu anda içinde tüm ihtiyaç duyduğu nesneleri de oluşturacak!
 *      
 *      Admin role = new Admin();
 *      role.Permissions
        DenizLojistik deniz = new DenizLojistik();
        deniz.Gemiler

 *    Turistlerin belirli bir kategoriyi seçerek; o kategoride ziyaret edilmesi gereken yerleri gösterdiği bir harita uygulaması yapmak istiyoruz. 
 *    
 *    Harita harita = new Harita(new Kultur());
 *    harita.ZiyaretEdileceklerYerler;
 */

ReligionMapGenerator religionMapGenerator = new ReligionMapGenerator();
religionMapGenerator.Show();

//public class Card
//{
//    public Card(string info)
//    {
//        Info = info;
//    }
//    public string Info { get; set; }
//}

//public class StockCard : Card
//{
//    public StockCard(string info) : base(info)
//    {
//    }
//}

//public class ProductCard : Card
//{
//    public ProductCard(string info) : base(info)
//    {
//    }
//}

//public class CardCreator
//{
//    public Card CreateCard(string type, string info)
//    {
//        switch (type)
//        {
//            case "stock":
//                return new StockCard(info);
//            case "product":
//                return new ProductCard(info);
//            default:
//                return null;
//                break;
//        }
//    }

//}

