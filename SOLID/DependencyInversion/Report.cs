using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface ISender
    {
        void Send();
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;   
        }
      
        public void Send()
        {
           
            sender.Send();
        }
    }



    public class MailSenderUpgrade : MailSender
    {

    }
}
