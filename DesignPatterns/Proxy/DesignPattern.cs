using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        double Sum(double x, double y);

    }

    //Asıl kişi:
    internal class Math : IMath
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
    }


    //Bu muhasebeci:
    public class MathProxy : IMath
    {
        private readonly IMath math;

        public MathProxy(IMath math)
        {
            this.math = math;
        }

        public double Sum(double x, double y)
        {
            if (x < 0 && y < 0)
            {
                throw new InvalidOperationException("değerler negatif olamaz");
            }
            return math.Sum(x, y);
        }
    }
}
