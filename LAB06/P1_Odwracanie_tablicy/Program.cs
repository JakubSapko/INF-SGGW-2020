using System;

namespace P1_Odwracanie_tablicy
{
    class Program
    {
        static int[] bezDodatkowej(int[] ar)
        {
            for (int i = 0; i<ar.Length/2; i++)
            {
                int tmp = ar[i];
                ar[i] = ar[ar.Length - i - 1];
                ar[ar.Length - i - 1] = tmp;
            }
            return ar;
        }

        static int[] zDodatkowa(int[] ar)
        {
            int[] arTemp = new int[ar.Length];
            int i = 0;
            for (int j = ar.Length-1; j>=0; j--)
            {
                arTemp[i] = ar[j];
                i++;
            }
            ar = arTemp;
            return ar;
        }
        static void Main(string[] args)
        {
            int[] ar = { 3, 4, 5 };
            Console.WriteLine("{0}{1}{2}", ar[0], ar[1], ar[2]);
            int[] ar1 = bezDodatkowej(ar);
            Console.WriteLine("{0}{1}{2}", ar1[0], ar1[1], ar1[2]);
            int[] ar2 = zDodatkowa(ar1);
            Console.WriteLine("{0}{1}{2}", ar2[0], ar2[1], ar2[2]);
        }
    }
}
