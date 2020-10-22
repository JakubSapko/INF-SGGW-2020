using System;

namespace RunCode
{
    class Program
    {
        static ulong Fibonacci(uint n)
        {
            // tu dodaj swój kod
            if (n < 3) { 
                if (n == 0) { return 0; }
                return 1;
            }

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
            Console.WriteLine(Fibonacci(4));
            Console.WriteLine(Fibonacci(13));
        }
    }
}
