// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
/*
 * Bir uygulamada; bir nesneden sadece ve sadece 1 adet instance olmasını istiyorsunuz. Bunu nasıl sağlarsınız?
 */
MailConfiguration mailConfiguration = MailConfiguration.CreateInstance();
mailConfiguration.Host = "gmail.com";
mailConfiguration.Port = 456;

MailConfiguration mailConfiguration2 = MailConfiguration.CreateInstance();
Console.WriteLine(mailConfiguration2.Host);

