using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /*
     * Senaryo: Bilet satış ekranı yapacaksınız; koltuk render edilerek görsele dönüştürülüyor. Bu da zaman alıyor... 
     * 
     */

    public class Chair : ICloneable
    {
        public Chair()
        {
            Console.WriteLine($"{DateTime.Now}: nesne oluşturuluyor");
            Thread.Sleep(10000);
            Console.WriteLine($"{DateTime.Now}: nesne oluştu");
            ChairNo = 1;
            ChairLetter = "A";
            DefaultColor = "Black";

            Cinema = new Cinema { Movie = "King Kong", MovieTime = DateTime.Now };
        }

        public int ChairNo { get; set; }
        public string ChairLetter { get; set; }
        public string DefaultColor { get; set; }

        public Cinema Cinema { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public object Clone(bool isDeepClone)
        {
            return isDeepClone ? deepClone() : Clone();
        }

        private object deepClone()
        {
            //klonlamak istediğiniz nesneyi (Chair) bellekte Serialize edin ve Deserialize ederek döndürün.
            return null;
        }

        public override string ToString()
        {
            return $"Koltuk sırası:{ChairLetter}, Numarası:{ChairNo}. Film: {Cinema.Movie}";
        }
    }

    public class Cinema
    {
        public string Movie { get; set; }
        public DateTime MovieTime { get; set; }

    }
}
