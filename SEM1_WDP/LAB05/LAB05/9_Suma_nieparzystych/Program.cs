using System;

namespace Zad09
{
    class Program
    {
        static long SumaNieparzystych(int[] T1, int n = 0)
        {
            if (T1 == null || T1.Length == 0)
            {
                return 0;
            }
            if (T1.Length <= n)
            {
                return 0;
            }
            if (T1[n] % 2 == 1)
            {
                return T1[n] + SumaNieparzystych(T1, n + 1);
            }
            return SumaNieparzystych(T1, n + 1);
        }
        static void Main(string[] args)
        {
            int[] tab = new int[4] { 2, 1, 3, 7 };
            Console.WriteLine(SumaNieparzystych(tab));
        }
    }
}