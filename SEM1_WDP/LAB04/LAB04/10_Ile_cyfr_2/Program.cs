using System;

namespace RunCode
{
    class Program
    {
        static uint IleCyfr2(ulong n)
        {
            // tu dodaj swój kod
            uint c = 0;
            if (n % 10 == 2) { c = 1; }
            if (n < 10) { return c; }
            return c + IleCyfr2(n / 10);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(IleCyfr2(2342323));
         }
    }
}
