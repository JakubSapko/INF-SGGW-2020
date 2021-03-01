using System;

namespace P3_Najwieksza
{
    class Program
    {
        static int ZnajdzMax(int[] T, int i)
        {
            if (i == 1) { return T[0]; }
            return Math.Max(T[i - 1], ZnajdzMax(T, i - 1));
        }
        static void Main(string[] args)
        {
            int[] W = { 2, 3, 5, 6, 1, 3, 2, 9 };
            Console.WriteLine(ZnajdzMax(W, W.Length));
        }
    }
}
