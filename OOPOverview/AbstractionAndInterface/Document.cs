using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    public abstract class Document
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public void Move(string from, string to)
        {

        }

        public abstract void Save();
        public abstract void Load();
        //public abstract void Print();


      

      
    }

    public interface IPrintable
    {
        public void Print();
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

      

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
