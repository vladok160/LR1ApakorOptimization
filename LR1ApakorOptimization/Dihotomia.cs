using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class Dihotomia : GlobalData, IAnswerMethods
    {
        public Dihotomia() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            Search();
        }

        public Dihotomia(double x0, double x1, double Epsilon)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.Epsilon = Epsilon;
            iterations = 0;
            Search();
        }

        public double GetF()
        {
            return f((x0 + x1) / 2);
        }

        public double GetIterations()
        {
            return iterations;
        }

        public double GetX()
        {
            return ((x0 + x1) / 2);
        }

        private void Search()
        {
            double x1dop = x0 + (x1 - x0) / 3, x2 = x1 - (x1 - x0) / 3;
            double f1 = f(x1dop), f2 = f(x2);

            while (Math.Abs(x1 - x0) > Epsilon)
            {
                if (f1 < f2)
                {
                    x1 = x2;
                    x2 = x1dop;
                    f2 = f1;
                    x1dop = x0 + (x1 - x0) / 3;
                    f1 = f(x1);
                }
                else
                {
                    x0 = x1dop;
                    x1dop = x2;
                    f1 = f2;
                    x2 = x1 - (x1 - x0) / 3;
                    f2 = f(x2);
                }
                iterations++;
            }
        }
    }
}
