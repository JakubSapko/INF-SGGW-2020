using System;


namespace RunCode
{
    class Program
    {
        static long SumaKwadratow(int[] tab1, int[] tab2)
        {
            return Convert.ToInt64(tab1[0]) * Convert.ToInt64(tab1[0]) + Convert.ToInt64(tab2[tab2.Length - 1]) * Convert.ToInt64(tab2[tab2.Length - 1]);
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
