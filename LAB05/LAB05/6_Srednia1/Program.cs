using System;

namespace RunCode
{
    class Program
    {
        static double Srednia1(int[] tab)
        {
            return (Convert.ToDouble(tab[0]) + Convert.ToDouble(tab[tab.Length - 1])) / 2;
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
