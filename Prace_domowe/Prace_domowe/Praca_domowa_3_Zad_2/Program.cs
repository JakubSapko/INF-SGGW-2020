using System;

namespace Praca_domowa_3_Zad_2
{
    class Program
    {
        static bool CzyTrojkat1(double a, double b, double c)
        {
            if ((a*a+b*b==c*c) || (a*a+c*c==b*b) || (b * b + c * c == a * a)) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzajacy czy podane trzy dlugosci bokow moglyby byc trojkatem prostokatnym");
            Console.WriteLine("Podaj trzy długości: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Czy te trzy długości mogłyby utworzyć trójkąt prostokątny? -> {0}", CzyTrojkat1(x, y, z));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Podano złe dane");
            }
        }
    }
}
