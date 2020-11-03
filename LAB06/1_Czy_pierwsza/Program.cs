using System;

namespace RunCode
{
    class Program
    {
        static bool CzyPierwsza(int a)
        {
            if (a > 1)
            {
                for (int i = 2; i <= a/2; i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
