using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{

  public interface ISortStrategy
    {
        void Sort();
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Bubble sort algoritması ile sıralandı");
        }
    }

    public class HeapSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Heap sort algoritması ile sıralandı");

        }
    }
    public class ProductCollection
    {
        public void Sort(ISortStrategy sortStrategy)
        {
            sortStrategy.Sort();
            //burada bubble sort algoritmasıyla sıralama yaptınız
        }
    }
}
