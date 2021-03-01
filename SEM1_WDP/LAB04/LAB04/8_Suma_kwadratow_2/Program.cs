using System;

namespace RunCode
{
    class Program
    {
        static ulong SumaKwadratow2(uint n)
        {
            // tu dodaj swój kod

            if (n == 0) { return 0; }
            n--;
            if (n == 1) { return 1; }
            return (n) * (n) + SumaKwadratow2(n);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
        }
    }
}
