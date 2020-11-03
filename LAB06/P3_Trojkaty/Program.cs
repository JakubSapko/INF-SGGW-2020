using System;

namespace P3_Trojkaty
{
    class Program
    {
        static void Trojkat1(int rozmiar)
        {
            for (int i=1; i<=rozmiar; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Trojkat1(5);
        }
    }
}
