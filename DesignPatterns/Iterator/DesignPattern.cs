using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
  * Problem: Bellekteki bir nesne koleksiyonu içerisinde; navigasyon yapma ihtiyacınız var. Yani ileri, geri, başa dön, sona git gibi eylemleri yapmak istiyorsunuz. Bu sistemi nasıl tasarlarsınız?
  */

    public class IteratorClass : IEnumerator<string>
    {
        int position = 0;

        private readonly List<string> words;

        public IteratorClass(List<string> words)
        {
            this.words = words;
        }

        public string Current => words[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            position = 0;
        }

        public bool MoveNext()
        {
            position++;
            return position < words.Count;
        }

        public void Reset()
        {
            position = 0;
        }

        public string First()
        {
            position = 0;
            return words[position];
        }

        public string Last()
        {
            position = words.Count - 1;
            return words[position];
        }
    }

}
