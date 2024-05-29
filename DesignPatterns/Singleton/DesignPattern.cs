using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*Senaryo: Uygulamada Eposta göndermek için kullanılacak konfigürasyondan sadece bir adet olmasını istiyorsunuz*/

    public class MailConfiguration : IMailConfig
    {
        public string Host { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }

        private MailConfiguration()
        {

        }
        private static MailConfiguration instance;
        static object state;
        public static MailConfiguration CreateInstance()
        {
            lock (state)
            {
                if (instance == null)
                {
                    instance = new MailConfiguration();
                }

                return instance;
            }


        }

        public static MailConfiguration Instance
        {
            get
            {
                lock (state)
                {
                    if (instance == null)
                    {
                        instance = new MailConfiguration();
                    }

                    return instance;
                }
            }
        }
    }


    public interface IMailConfig
    {
        public static string Host { get; set; }
        public static string Password { get; set; }
        public static int Port { get; set; }
        public static bool EnableSSL { get; set; }
    }

    //public static class StaticMailConfiguration : IMailConfig
    //{
    //    public static string Host { get; set; }
    //    public static string Password { get; set; }
    //    public static int Port { get; set; }
    //    public static bool EnableSSL { get; set; }

    //}
}
