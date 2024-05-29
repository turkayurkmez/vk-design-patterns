using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /*
   * Karmaşık aşamalardan oluşan büyük bir nesnemiz var. Bu büyük nesneden başka nesneler de türetmek istiyorsunuz. Söz gelimi bu karmaşık adımları her miras yapısında yönetmek nasıl mümkün olur?
   * 
   * Çözüm:
   * Her aşamayı başka bir nesneye ayır. Başka bir nesne de bu aşamalarının sırasını yönetsin.
   * 
   * Senaryo:
   *  Karmaşık bir haftalık rapor oluşturmanız gerekiyor. Her parçası büyük bir db'nin farklı alanlarından geliyor.
   * 
   */


    //1. Builder ne üretecek? (Genel adı: Product)
    public class Report
    {
        public string Title { get; set; }
        public string Data { get; set; }
        public string Graph { get; set; }
    }

    //2. Karmaşık nesnenizi (Rapor) oluşturacak aşamalrı belirten arayüz ile başlayın:

    public interface IReportBuilder
    {
        void BuildTitle();
        void BuildData();
        void BuildGraph();

        Report GetBuildingReport();
    }

  

    //3. (1. Adımdaki) interface'i implemente eden bir Builder oluştur.
    public class WeeklySalesReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public Report GetBuildingReport() => report;

        public void BuildData()
        {
            report.Data = "Haftalık satış raporunun verileri çekiliyor";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık satış raporunun bar grafiği oluşturuldu";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık satış raporunun başlığı oluşturuldu";
        }
    }

    public class WeeklyPerformanceReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public Report GetBuildingReport() => report;

        public void BuildData()
        {
            report.Data = "Haftalık çalışan raporunun verileri çekiliyor";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık çalışan raporunun bar grafiği oluşturuldu";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık çalışan raporunun başlığı oluşturuldu";
        }
    }

    //4. raporun yapım aşamalarını (sırasını) yöneten Director sınfı:

    public class ReportBuilder
    {
        public IReportBuilder Builder { get; set; }
        public Report Build()
        {
            Builder.BuildTitle();
            Builder.BuildData();
            Builder.BuildGraph();

            return Builder.GetBuildingReport();
        }
    }


}
