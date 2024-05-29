// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
/*
 * Karmaşık aşamalardan oluşan büyük bir nesnemiz var. Bu büyük nesneden başka nesneler de türetmek istiyorsunuz. Söz gelimi bu karmaşık adımları her miras yapısında yönetmek nasıl mümkün olur?
 * 
 */

ReportBuilder reportBuilder = new ReportBuilder();
reportBuilder.Builder = new WeeklySalesReportBuilder();
var report = reportBuilder.Build();
Console.WriteLine($"{report.Title}\n{report.Data}\n{report.Graph}");
