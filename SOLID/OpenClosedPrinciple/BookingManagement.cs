using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{

    //public enum CountryInfo
    //{
    //    Germany,
    //    Sweden,
    //    Turkiye,
    //    Italy
    //}

    public abstract class CountryInfo
    {
        public abstract void CreateOnDb();       
    }

    public class Turkiye : CountryInfo
    {
        public override void CreateOnDb()
        {
            Console.WriteLine("Türkiye db'si ile çalışıldı");
        }
    }

    public class Sweden : CountryInfo
    {
        public override void CreateOnDb()
        {
            Console.WriteLine("İsveç db'si ile çalışıldı");
        }
    }

    public class Germany : CountryInfo
    {
        public override void CreateOnDb()
        {
            Console.WriteLine("Almanya db'si ile çalışıldı");
        }
    }

    public class Italy : CountryInfo
    {
        public override void CreateOnDb()
        {
            Console.WriteLine("İtalya db'si ile çalışıldı");
        }
    }


    public class BookingDetails
    {
        public string Owner { get; set; }
        public DateTime CheckInDate { get; set; }
        public CountryInfo CountryInfo { get; set; }

    }
    public class BookingManagement
    {
        public BookingDetails BookingDetails { get; set; }
        public void CreateBookingOnDb()
        {
            //switch (BookingDetails.CountryInfo)
            //{
            //    case CountryInfo.Germany:
            //        Console.WriteLine("Almanya db'si ile çalışıldı");
            //        break;
            //    case CountryInfo.Sweden:
            //        Console.WriteLine("İsveç db'si ile çalışıldı");

            //        break;
            //    case CountryInfo.Turkiye:
            //        Console.WriteLine("Türkiye db'si ile çalışıldı");                      

            //        break;
            //    default:
            //        break;
            //}

            BookingDetails.CountryInfo.CreateOnDb();
        }
    }
}
