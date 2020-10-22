using System;

namespace RunCode
{
    class Program
    {
        static uint Suma2(uint n)
        {
            // tu dodaj swój kod
            if (n == 0) { return 0; }
            else { return (n-1) + Suma2(n - 1); }

        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(Suma2(10));
        }
    }
}
