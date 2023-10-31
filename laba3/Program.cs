using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_01_И_цикл_Сшарп
{
    class Program
    {
        static double f(double x)
        {
            return Math.Tan(x) + (1.0 / 3.0) * Math.Pow(Math.Tan(x), 3) + (1.0 / 5.0) * Math.Pow(Math.Tan(x), 5) - (1.0 / 3.0);
        }

        static double методСекущих(double x0, double x1, double точность)
        {
            double x2 = 0;
            double f0 = f(x0);
            double f1 = f(x1);

            while (Math.Abs(x1 - x0) > точность)
            {
                x2 = x1 - f1 * (x1 - x0) / (f1 - f0);
                x0 = x1;
                x1 = x2;
                f0 = f1;
                f1 = f(x1);
            }

            return x2;
        }

        static void Main(string[] args)
        {
            double x0 = 0;
            double x1 = 0.8;
            double точность = 0.0001;

            double корень = методСекущих(x0, x1, точность);

            Console.WriteLine("Корень: " + корень);
            Console.ReadLine();
        }
    }
}
