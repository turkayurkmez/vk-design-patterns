using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public class Geometry
    {
        public IArea CreateRectangle(int unit1, int? unit2=null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
            return new Square() {  EdgeLength = unit1};
        }
    }

    public interface IArea {

        double GetArea();
    }
    public class Rectangle : IArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double GetArea() => Width * Height;
    }

    public class Square : IArea //: Rectangle
    {

        public double EdgeLength { get; set; }
        public double GetArea() => EdgeLength * EdgeLength;


    }
}
