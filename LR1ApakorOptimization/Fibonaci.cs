using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class Fibonaci: GlobalData, IAnswerMethods
    {
        int n;
        double x1dop, x2dop, f1, f2;

        public Fibonaci() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            n = FibonacciSearch(x0, x1, Epsilon);
            x1dop = x0 + (double)Fibonacci(n - 2) / Fibonacci(n) * (x1 - x0);
            x2dop = x0 + (double)Fibonacci(n - 1) / Fibonacci(n) * (x1 - x0);
            f1 = f(x1dop);
            f2 = f(x2dop);
            Search();
        }

        public Fibonaci(double x0, double x1, double Epsilon)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.Epsilon = Epsilon;
            iterations = 0;

            n = FibonacciSearch(x0, x1, Epsilon);
            x1dop = x0 + (double)Fibonacci(n - 2) / Fibonacci(n) * (x1 - x0);
            x2dop = x0 + (double)Fibonacci(n - 1) / Fibonacci(n) * (x1 - x0);
            f1 = f(x1dop);
            f2 = f(x2dop);

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
            return (x0 + x1) / 2;
        }

        private void Search()
        {
            while (n > 2)
            {
                n--;
                if (f1 < f2)
                {
                    x1 = x2dop;
                    x2dop = x1dop;
                    f2 = f1;
                    x1dop = x0 + (double)Fibonacci(n - 2) / Fibonacci(n) * (x1 - x0);
                    f1 = f(x1dop);
                }
                else
                {
                    x0 = x1dop;
                    x1dop = x2dop;
                    f1 = f2;
                    x2dop = x0 + (double)Fibonacci(n - 1) / Fibonacci(n) * (x1 - x0);
                    f2 = f(x2dop);
                }
                iterations++;
            }
        }

        public int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        public int FibonacciSearch(double a, double b, double eps)
        {
            int n = 0;
            while (Fibonacci(n) <= (b - a) / eps)
            {
                n++;
            }
            return n;
        }
    }
}
