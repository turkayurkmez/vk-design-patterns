using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //...is a 
    //... has a

    public class Format
    {

    }
    public class Report
	{
        public Format Format { get; set; }
    }

   

    public class SalesReport: Report
    {
        
    }

    public class PerformanceReport : Report
    {

    }

    public class  PDFFormat: Format
    {

    }

    public class HTMLFormat: Format
    {

    }
}
