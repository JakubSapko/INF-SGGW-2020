using System;

namespace RunCode
{
    class Program
    {
        static bool CzyJest(int[] T1, int a, int n = 0)
        {
            bool wynik = false;
            if (n == T1.Length)
                return false;
            if (T1[n] == a)
                wynik = true;
            return wynik || CzyJest(T1, a, ++n);
        }
            //moze posortowac i recursive binary search?
            static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
