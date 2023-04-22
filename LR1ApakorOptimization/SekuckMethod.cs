using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class SekuckMethod : GlobalData, IAnswerMethods
    {
        // Максимальное число итераций
        int maxIterations;
        double f0;
        double f1;
        double x2;
        double oldXMinus;
        double oldXPlus;
        TimeSpan elapsedTime;

        public SekuckMethod() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            f0 = Math.Exp(-2 - x0) + Math.Pow(x0, 2) / 2;
            f1 = Math.Exp(-2 - x1) + Math.Pow(x1, 2) / 2;
            maxIterations = 1000;
            Search();
        }

        public SekuckMethod(double x0, double x1, double Epsilon)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.Epsilon = Epsilon;
            maxIterations = 100;
            iterations = 0;
            oldXMinus = x0;
            oldXPlus = x1;
            f0 = Math.Exp(-2 - x0) + Math.Pow(x0, 2) / 2;
            f1 = Math.Exp(-2 - x1) + Math.Pow(x1, 2) / 2;

            Search();
        }

        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime);
        }

        public double GetErrorRate()
        {
            return ((Math.Abs(0.127 - f(x2))) / 0.127) * 100;
        }

        public double GetF()
        {
            if (oldXMinus < 0 && (oldXPlus == 0 || (oldXPlus < 0 && oldXPlus > oldXMinus) || oldXPlus > 0))
            {
                return f(oldXPlus);
            }
            else if (oldXMinus > 1 && (oldXPlus > oldXMinus))
            {
                return f(oldXMinus);
            }
            else
            {
                return f(x2);
            }
            //return f(x2);
        }

        public double GetIterations()
        {
            return iterations;
        }

        public double GetX()
        {
            if (oldXMinus < 0 && (oldXPlus == 0 || (oldXPlus < 0 && oldXPlus > oldXMinus) || oldXPlus > 0))
            {
                return oldXPlus;
            }
            else if (oldXMinus > 0 && (oldXPlus > oldXMinus))
            {
                return oldXMinus;
            }
            else
            {
                return -x2;
            }
        }

        private void Search()
        {
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < maxIterations; i++)
            {
                // Расчет следующей точки x2
                x2 = x1 - f1 * (x1 - x0) / (f1 - f0);

                // Значение функции в точке x2
                double f2 = f(x2);

                // Проверка на достижение заданной точности
                if (Math.Abs(x2 - x1) < Epsilon)
                {
                    //Console.WriteLine("Метод Секущих сошелся к решению x = {0} после {1} итераций", x2, i + 1);
                    break;
                }
                iterations++;
                // Обновление переменных
                x0 = x1;
                f0 = f1;
                x1 = x2;
                f1 = f2;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}
