using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class GoldSearch : GlobalData, IAnswerMethods
    {
        double phi, x1_new, x2_new, Answ;
        public GoldSearch() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            phi = (1 + Math.Sqrt(5)) / 2;
            double x1_new = x1 - (x1 - x0) / phi;
            double x2_new = x0 + (x1 - x0) / phi;
            Answ = 0;
            Search();
        }
        public GoldSearch(double x0, double x1, double Epsilon)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.Epsilon = Epsilon;
            phi = (1 + Math.Sqrt(5)) / 2;
            x1_new = x1 - (x1 - x0) / phi;
            x2_new = x0 + (x1 - x0) / phi;
            Answ = 0;
            iterations = 0;
            Search();
        }
        public double GetErrorRate()
        {
            return ((Math.Abs(0.127 - f(Answ))) / 0.127) * 100;
        }
        public double GetF()
        {
            return f(Answ);
        }

        public double GetIterations()
        {
            return iterations;
        }

        public double GetX()
        {
            return Answ;
        }
        private void Search()
        {
            while (Math.Abs(x1 - x0) > Epsilon)
            {
                if (f(x1_new) < f(x2_new))
                {
                    x1 = x2_new;
                    x2_new = x1_new;
                    x1_new = x1 - (x1 - x0) / phi;
                }
                else
                {
                    x0 = x1_new;
                    x1_new = x2_new;
                    x2_new = x0 + (x1 - x0) / phi;
                }
                iterations++;
            }
            Answ = (x0 + x1) / 2;
        }
    }
}
