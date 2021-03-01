using System;

namespace Praca_domowa_3_Zad_5
{
    class Program
    {
        static bool Sprawdz1(int a)
        {
            return (a % 3 == 0 && a % 7 == 0);
        }
        
        static bool Sprawdz2(int a)
        {
            return (a % 7 == 0 && a % 6 != 0);
        }

        static bool Sprawdz3(int a)
        {
            return (a % 7 == 0 || a % 11 == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sprawdz1(3));
            Console.WriteLine(Sprawdz1(7));
            Console.WriteLine(Sprawdz1(21));
            Console.WriteLine(Sprawdz2(7));
            Console.WriteLine(Sprawdz2(42));
            Console.WriteLine(Sprawdz2(36));
            Console.WriteLine(Sprawdz3(7));
            Console.WriteLine(Sprawdz3(11));
            Console.WriteLine(Sprawdz3(40));
        }
    }
}
