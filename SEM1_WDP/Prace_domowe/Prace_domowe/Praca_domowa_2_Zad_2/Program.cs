using System;

namespace Praca_domowa_2_Zad_2
{
    class Program
    {
        static double ObliczPromien(uint obwod)
        {
            return obwod / (2 * Math.PI);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczajacy promien okregu na podstawie jego obwodu");
            Console.WriteLine("Podaj obwód:");
            uint x = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Promien tego okregu wynosi: {0}", ObliczPromien(x));
        }
    }
}
