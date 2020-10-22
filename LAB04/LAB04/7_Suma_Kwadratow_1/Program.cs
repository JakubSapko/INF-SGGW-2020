using System;

namespace RunCode
{
    class Program
    {
        static uint SumaKwadratow1(uint n)
        {
            // tu dodaj swój kod
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            return n*n + SumaKwadratow1(n - 1);

        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(SumaKwadratow1(10));
        }
    }
}
