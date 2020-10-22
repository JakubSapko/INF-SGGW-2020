using System;

namespace RunCode
{
    class Program
    {
        static ulong SumaLiczb(uint n)
        {
            // tu dodaj swój kod
            if ( n>0)
            {
                if ((n-1)%3==0 && (n - 1) % 7 > 0) { return n - 1 + SumaLiczb(n - 1); }
                else { return SumaLiczb(n - 1); }
            }
            else
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
        }
    }
}
