// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

/*
 * Hali hazırda bellekte varolan (erişilebilir) bir nesneye yeni özellikler eklemek istiyorsunuz. Bunu nasıl yaparsınız?
 * 
 */

//Stream file = new FileStream("test.txt", FileMode.CreateNew);
//Stream memory = new MemoryStream();
////Stream network = new NetworkStream

//GZipStream zipped = new GZipStream(file, CompressionMode.Compress);
//CryptoStream cryptoStream = new CryptoStream(zipped, null, CryptoStreamMode.Write);


Mail mail = new Mail();
SignedMail signedMail = new SignedMail(mail, "Türkay Ürkmez");
CryptedMail cryptedMail = new CryptedMail(signedMail);
cryptedMail.Send();