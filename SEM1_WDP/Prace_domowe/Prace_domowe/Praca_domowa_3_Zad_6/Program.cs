using System;

namespace Praca_domowa_3_Zad_6
{
    class Program
    {
        static int Max(int a, int b, int c)
        {
            if (a > b && a > c) { return a; }
            else if (b > a && b > c) { return b; }
            else  { return c; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Max(3, 4, 5));
            Console.WriteLine(Max(-1, -5, 3));
            Console.WriteLine(Max(3, 3, 3));
            Console.WriteLine(Max(2, 5, 3));
        }
    }
}
