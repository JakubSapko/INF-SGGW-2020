using System;

namespace RunCode
{
    class Program
    {
        static ulong SumaNieparzystych1(uint n)
        {
            if (n==0) { return 0; }
            if (n == 1) { return 1; }
            else
            {
                if (n % 2 == 0)
                {
                    return SumaNieparzystych1(n - 1);
                }
                else
                {
                    return n + SumaNieparzystych1(n - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(SumaNieparzystych1(6));
            Console.WriteLine(SumaNieparzystych1(10));
        }
    }
}
