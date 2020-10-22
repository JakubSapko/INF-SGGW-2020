using System;

namespace RunCode
{
    class Program
    {
        static ulong Silnia(uint n)
        {
            // tu dodaj swój kod
            if (n < 1) { return 1; }
            return n*Silnia(n - 1);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(Silnia(5));
            Console.WriteLine(Silnia(7));
        }
    }
}
