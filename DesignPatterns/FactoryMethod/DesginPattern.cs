using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

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
 *    Harita harita = new Harita<Kultur>();
 *    harita.ZiyaretEdileceklerYerler;
 */
    public interface IVisitPoint
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }

    }

    public class SultanahmetCamii : IVisitPoint
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
    }

    public class AyasofyaCamii : IVisitPoint
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
    }

    public class TopkapiSarayi : IVisitPoint
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
    }

    public class YerebatanSarnici : IVisitPoint
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Name { get; set; }
    }

    //1. Product: Fabrikanızın üreteceği ürünü interface olarak tanımla:
    public interface IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
    }

    //2. Concrete Products: üretmek istediğiniz nihai nesneleri impelemte edin.
    public class ReligionMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }

    }

    public class CultureMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
    }

    public class GastrologyMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    //3. Creator sınıfı: ihtiyaç duyduğunuz ürünü oluşturacak sınıf. 
    public abstract class MapGenerator
    {
        protected IMap map;

        protected abstract void CreateMap();

        protected MapGenerator()
        {
            CreateMap();    
        }
        public void Show()
        {
            foreach (var visitPoint in map.VisitPoints)
            {
                Console.WriteLine(visitPoint.Name);
            }
        }
    }

    public class ReligionMapGenerator : MapGenerator
    {
        
        protected override void CreateMap()
        {
            ReligionMap religionMap = new ReligionMap();
            religionMap.VisitPoints = new List<IVisitPoint>();
            religionMap.VisitPoints.Add(new AyasofyaCamii() {  Name ="Ayasofya"});
            religionMap.VisitPoints.Add(new SultanahmetCamii() {  Name ="Sultanahmet"});

            this.map = religionMap;
        }
    }


    public class CultureMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
            CultureMap cultureMap = new CultureMap();
            cultureMap.VisitPoints.Add(new YerebatanSarnici() {  Name = "Yere batan sarnıcı"});
            cultureMap.VisitPoints.Add(new TopkapiSarayi() { Name ="Topkapı Sarayı"});
            this.map = cultureMap;
        }
    }

    public class GastrologyMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
            throw new NotImplementedException();
        }
    }
}
