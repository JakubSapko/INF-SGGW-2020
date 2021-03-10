using System;

namespace Zadanie3
{
    static class Klasa
    {
        public static string Zamiana(this int n, int b)
        {
            string s = "";
            while (n > 0)
            {
                s = n % b + s;
                n = n / b;
            }
            return s;
        }
        public static int Suma(this int[] t)
        {
            int suma = 0;
            foreach (int i in t)
            {
                suma = suma + t[i];
            }
            return suma;
        } 
    }
    class Program
    {
        static string Zamiana(int n, int b)
        {
            string s = "";
            while (n > 0)
            {
                s = n % b+s;
                n = n / b;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Zamiana(7, 2));
            Console.WriteLine(Zamiana(7, 4));
            Console.WriteLine(7.Zamiana(4));
        }
    }
}
