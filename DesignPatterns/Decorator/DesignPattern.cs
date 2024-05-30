using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   //1. Ana nesne (espresso) ile dekore edilmiş nesne (latte) aynı interface ya da abstract sınıfı implemente etmelidir.
   public interface IMail
    {
        void Send();
    }

    //2. Ana nesnenizi oluşturun:
    public class Mail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    //3. Ana nesneye istenen özellikleri eklemek üzerine kullanılacak bir yapıcı nesne:
    public abstract class MailDecorator : IMail
    {
        protected readonly IMail _mail;

        protected MailDecorator(IMail mail)
        {
            _mail = mail;
        }

        public virtual void Send()
        {
            _mail.Send();
        }
    }

    public class SignedMail : MailDecorator
    {
        private readonly string signedBy;
        public SignedMail(IMail mail, string signedBy) : base(mail)
        {
            this.signedBy = signedBy;
        }

        private void SignMail()
        {
            Console.WriteLine($"mail {signedBy} olarak imzalandı");
        }
        public override void Send()
        {
            SignMail();
            base.Send();
        }
    }

    public class CryptedMail : MailDecorator
    {
        public CryptedMail(IMail mail) : base(mail)
        {
        }

        private void CryptMail()
        {
            Console.WriteLine("Mail şifrelendi");
        }

        public override void Send()
        {
            CryptMail();
            base.Send();
        }
    }



}
