using System;

namespace Zadanie5
{
    class Program
    {
        static double Potega(double w, int a)
        {
            for (int i = 1; i < a; i++)
            {
                w = w * w;
            }
            return w;
        }
        static double Sinus(double w)
        {
            return Math.Sin(w);
        }
        static double Cosinus(double w)
        {
            return Math.Cos(w);
        }
        static double Dodaj(double w, double x)
        {
            return w+x;
        }
        static double Odejmij(double w, double x)
        {
            return w-x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Potega(3.0, 2));
        }
    }
}
