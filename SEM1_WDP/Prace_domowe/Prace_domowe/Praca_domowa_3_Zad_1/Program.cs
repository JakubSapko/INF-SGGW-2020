using System;
using System.Security.Cryptography.X509Certificates;

namespace Praca_domowa_3_Zad_1
{
    class Program
    {
        static double Oblicz1(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczajacy dlugosc przeciwprostokatnej trojkata prostokatnego");
            Console.WriteLine("Podaj dlugosci boków a i b: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Długość przeciwprostokątnej wynosi: {0}", Oblicz1(x, y));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Podano nieprawidlowe dane");
            }
        }
    }
}
