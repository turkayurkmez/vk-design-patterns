using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{

    /*
     * Tüm avrupaya hizmet veren seminer/konferans organizasyon şirketi var. Veritabanınızda her ülke için yarı yapılar var. Buna göre rezervasyon işlevini CoR ile çözeceğiz.
     */

    public class Reservation
    {
        public string Owner { get; set; }
        public DateOnly CheckIn { get; set; }
        public DateOnly CheckOut { get; set; }
        public int PartipicantsCount { get; set; }
        public string Country { get; set; }
    }

    public interface IHandler
    {
        public IHandler Next { get; set; }
        void Handler(Reservation reservation);

    }

    public abstract class HandlerBase : IHandler
    {
        public IHandler Next { get; set; }

        protected HandlerBase()
        {
                
        }

        protected HandlerBase(HandlerBase handlerBase)
        {
            Next = handlerBase;
        }
        public abstract void Handler(Reservation reservation);
      
    }

    /*
     *   1. Halka: Kim rezerve ediyor belli mi?
     *   2. Tarihler uyumlu mu?
     *   3. Ülke (Fransa, İtalya, Türkiye) mi?
     */

    public class CheckOwnerHandler : HandlerBase
    {
        public CheckOwnerHandler()
        {
        }

        public CheckOwnerHandler(HandlerBase handlerBase) : base(handlerBase)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (string.IsNullOrEmpty(reservation.Owner))
            {
                throw new Exception("Rezervasyon kimin adına?");
            }
            Next.Handler(reservation);
        }
    }

    public class CheckInAndOutHandler : HandlerBase
    {
        public CheckInAndOutHandler()
        {
        }

        public CheckInAndOutHandler(HandlerBase handlerBase) : base(handlerBase)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (reservation.CheckIn >= reservation.CheckOut)
            {
                throw new Exception("Tarihler tutarsız");
            }
            Next.Handler(reservation);
        }
    }

    public class CheckCountryItalyHandler : HandlerBase
    {
        public CheckCountryItalyHandler()
        {
        }

        public CheckCountryItalyHandler(HandlerBase handlerBase) : base(handlerBase)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (reservation.Country == "Italy")
            {
                Console.WriteLine("İtalya db'si ile işlem tamam");
            }
            else
            {
                Next.Handler(reservation);
            }
             
        }
    }

    public class CheckCountryFranceHandler : HandlerBase
    {
        public CheckCountryFranceHandler()
        {
        }

        public CheckCountryFranceHandler(HandlerBase handlerBase) : base(handlerBase)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (reservation.Country == "France")
            {
                Console.WriteLine("Fransa db'si ile işlem tamam");
            }
            else
            {
                Next.Handler(reservation);
            }

        }
    }

    public class CheckCountryTurkiyeHandler : HandlerBase
    {
        public CheckCountryTurkiyeHandler()
        {
        }

        public CheckCountryTurkiyeHandler(HandlerBase handlerBase) : base(handlerBase)
        {
        }

        public override void Handler(Reservation reservation)
        {
            if (reservation.Country == "Türkiye")
            {
                Console.WriteLine("Türkiye db'si ile işlem tamam");
            }
            else
            {
                if (Next != null)
                {
                    Next.Handler(reservation);
                }
              
            }

        }
    }


}
