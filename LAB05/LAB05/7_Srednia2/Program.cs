using System;

namespace RunCode
{
    class Program
    {
        static double Srednia2(int[] tab, int a, int b)
        {
            return (Convert.ToDouble(tab[a]) + Convert.ToDouble(tab[b])) / 2;
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
