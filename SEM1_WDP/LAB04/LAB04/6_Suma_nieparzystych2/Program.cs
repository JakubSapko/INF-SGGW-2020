using System;

namespace RunCode
{
    class Program
    {
        static ulong SumaNieparzystych2(uint n)
        {
            if (n != 0)
            {
                n -= 1;
                if (n <= 0) { return 0; }
                if (n % 2 == 0) { n--; }
                return n + SumaNieparzystych2(n);
            }
            else { return 0; }
        }

        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(SumaNieparzystych2(0));
            Console.WriteLine(SumaNieparzystych2(10));
            Console.WriteLine(SumaNieparzystych2(11));
        }
    }
}
