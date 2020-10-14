using System;

namespace Praca_domowa_2_Zad_3
{
    class Program
    {
        static double ObliczDelte(int a, int b, int c)
        {
            return (Math.Pow(b, 2) - 4 * a * c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program przyjmujacy wspolczynniki funkcji kwadratowej i obliczajacy jej delte");
            Console.WriteLine("Podaj kolejno wspolczynniki a, b oraz c: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoja funkcja jest postaci: y={0}x^2+{1}x+{2}, a jej delta wynosi: {3}", a, b, c, ObliczDelte(a, b, c));
        }
    }
}
