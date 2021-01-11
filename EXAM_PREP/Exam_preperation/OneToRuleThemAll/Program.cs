using System;

namespace OneToRuleThemAll
{
    class Program
    {
        //--- Exercise 1 - Counting how many numbers starting with "7" are there in an array of numbers ---//
        static int Ile(int[] T)
        {
            int counter = 0;
            for (int i = 0; i<T.Length; i++)
            {
                int dana = Math.Abs(T[i]);
                while (dana >= 10)
                {
                    dana /= 10;
                }
                if (dana == 7)
                {
                    counter++;
                }
            }
            return counter;
        }
        //--- Exercise 2 - summing every number that isnt divisible by 3 and, at the same time, is divisible by 7 in a given range ---//
        static int Sumuj(int start, int koniec)
        {
            int bufor = start;
            int suma = 0;
            while (bufor <= koniec)
            {
                if (bufor % 3 != 0 && bufor % 7 == 0)
                {
                    suma += bufor;
                }
                bufor++;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int[] T = { 1, 71, 17, 77, 700, 70000, 713411345, 1, 3, 0, 15 };
            Console.WriteLine(Ile(T));
            Console.WriteLine(Sumuj(3, 21));
        }
    }
}
