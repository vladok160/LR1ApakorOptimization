using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    public abstract class GlobalData
    {
        public double x0, x1, Epsilon;
        public int iterations;
        public GlobalData()
        {
            x0 = 0;
            x1 = 1;
            Epsilon = 0.001;
            iterations = 0;
        }
        public double f(double x)
        {
            return Math.Exp(-2 - x) + Math.Pow(x, 2) / 2;
        }
        public double df(double x)
        {
            return -Math.Exp(-2 - x) + x;
        }
        public double ddf(double x)
        {
            return 1 + Math.Exp(-2 - x);
        }
    }
}
