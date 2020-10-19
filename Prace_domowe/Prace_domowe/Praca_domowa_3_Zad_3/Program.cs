using System;

namespace Praca_domowa_3_Zad_3
{
    class Program
    {
        static bool CzyTrojkat2(double a, double b, double c)
        {
            if ((a<b+c) || (b<a+c) || (c<a+b)) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający czy dane długości boków mogłyby utworzyć trójkąt");
            Console.WriteLine("Podaj długości: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Czy te długości mogłyby utworzyć trójkąt? -> {0}", CzyTrojkat2(x, y, z));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Niepoprawne dane");
            }
        }
    }
}
