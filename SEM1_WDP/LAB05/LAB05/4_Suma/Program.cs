using System;

namespace RunCode
{
    class Program
    {
        static long Suma(int[] tab)
        {
            if(tab!=null && tab.Length != 0)
            {
                return Convert.ToInt64(tab[0]) + Convert.ToInt64(tab[tab.Length - 1]);
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            /*Console.ReadKey();
            int[] tab = { 5, 2147483647};
            Console.WriteLine(tab.Length);
            Console.WriteLine(Suma(tab));*/
        }
    }
}
