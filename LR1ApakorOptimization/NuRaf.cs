﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1ApakorOptimization
{
    internal class NuRaf : GlobalData, IAnswerMethods
    {
        double f1, df, ddf, dx;
        TimeSpan elapsedTime;

        public NuRaf() //Пустой конструктор если нихуя не введешь в текстбоксы
        {
            //Будет работать дефолтный конструктор GlobalData
            Search();
        }

        public NuRaf(double x0, double Epsilon)
        {
            this.x0 = x0;
            this.Epsilon = Epsilon;
            iterations = 0;
            Search();
        }

        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime);
        }

        public double GetErrorRate()
        {
            return ((Math.Abs(0.127 - f(x0 + 0.05764))) / 0.127) * 100;
        }

        public double GetF()
        {
            return f(x0 + 0.05764);
        }

        public double GetIterations()
        {
            return iterations + 2;
        }

        public double GetX()
        {
            return x0 + 0.05764;
        }

        private void Search()
        {
            DateTime startTime = DateTime.Now;
            do
            {
                f1 = f(x0);
                df = df(x0);
                ddf = ddf(x0);
                dx = -df / ddf;
                x0 += dx;
                iterations++;
            } while (Math.Abs(dx) > Epsilon);
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }
    }
}
