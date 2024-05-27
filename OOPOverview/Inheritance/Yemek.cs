using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public double Fiyat { get; set; }
        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; } = 5;
        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, yanında pilav ile sunuldu");

        }
    }

    public class Corba: Yemek
    {
        public bool KitirEkmekOlsunMu { get; set; }
        public bool SogukMu { get; set; }

    }

    public class DomatesCorbasi : Corba
    {
        public int KasarMiktari { get; set; }
    }

    public class EtYemek : Yemek
    {

    }

    public class Kofte: EtYemek
    {
        public override void SunumYap()
        {
            Console.WriteLine(" köfte yanına turşu eklendi");
            base.SunumYap();
        }

    }

    public class Tatli : Yemek
    {

    }

    public class Tulumba: Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, yanında dondurma ile sunuldu");

        }

    }



}
