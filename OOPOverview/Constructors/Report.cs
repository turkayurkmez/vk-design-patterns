using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Report
    {
        public string ExcelFilePath { get; set; }
        public string Format { get; set; }

        public Report(string excelFilePath) : this(format:"PDF", excelFilePath:excelFilePath)
        {
            //C# dilinde bir constructor diğer  bir constructor'u this ile çağrır.
            //Format = "PDF";
            //ExcelFilePath = excelFilePath;
        }

        public Report(string format, string excelFilePath)
        {
            Format = format;
            ExcelFilePath = excelFilePath;
        }

    }
}
