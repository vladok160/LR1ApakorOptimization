using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class PassiveSearch : GlobalData, IAnswerMethods
    {
        double delta;
        double AnswX, AnxswY;
        TimeSpan elapsedTime;
        public PassiveSearch() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            AnswX = 0;
            AnxswY = 0;
            delta = Epsilon / 10;
            Search();
        }
        public PassiveSearch(double a, double b, double Epsilon)
        {
            x0 = a;
            x1 = b;
            this.Epsilon = Epsilon;
            delta = Epsilon / 10; ; // шаг
            iterations = 0;
            AnswX = 0;
            AnxswY = 0;

            Search();
        }

        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime);
        }

        public double GetErrorRate()
        {
            return ((Math.Abs(0.127 - AnxswY)) / 0.127) * 100;
        }

        public double GetX()
        {
            return AnswX;
        }

        public double GetF()
        {
            return AnxswY;
        }

        public double GetIterations()
        {
            return iterations;
        }

        private void Search()
        {
            DateTime startTime = DateTime.Now;
            int n = (int)Math.Ceiling((x1 - x0) / delta); // количество точек для перебора
            double xmin = x0; // начальное значение минимума
            double fmin = f(x0); // начальное значение функции в минимуме

            for (int i = 1; i <= n; i++)
            {
                double xi = x0 + i * delta;
                double fi = f(xi);

                if (fi < fmin)
                {
                    xmin = xi;
                    fmin = fi;
                }
                iterations++;
            }
            AnswX = xmin;
            AnxswY = fmin;
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}
