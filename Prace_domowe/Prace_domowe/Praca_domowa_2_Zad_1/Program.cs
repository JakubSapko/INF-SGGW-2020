using System;

namespace Praca_domowa_2_Zad_1
{
    class Program
    {
        static double ObliczDlugoscPrzeciwprostokatnej(uint a, uint b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający wartość przeciwprostokątnej");
            Console.WriteLine("Podaj wartości przyprostokątnych: ");
            uint xOut = Convert.ToUInt32(Console.ReadLine());
            uint yOut = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Wartość przeciwprostokątnej to: {0}", ObliczDlugoscPrzeciwprostokatnej(xOut, yOut));

        }
    }
}
