using Constructors;

Report report = new Report(excelFilePath: "C:\\test.xlsx");
Console.WriteLine(report.Format);

Report report2 = new Report(excelFilePath: "C:\\test.xlsx", format:"HTML");
Console.WriteLine(report2.Format);


