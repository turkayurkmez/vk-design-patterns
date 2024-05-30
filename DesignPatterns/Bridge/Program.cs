// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

/*
 * Bir sınıftan miras alan birkaç sınıfınız var. Bu alt sınıflardan da başka sınıflar miras almalı. Fakat her iki kırılımda ayrı ayrı geliştirme yapılabilir. Intheritance Chaos nasıl önlenir?
 */

SalesReport salesReport = new SalesReport();
salesReport.Format = new PDFFormat();