using System;

namespace RunCode
{
    class Program
    {
        static bool CzyParzysta(int a)
        {
            // tu dodaj swój kod
            return Convert.ToBoolean(a % 2 == 0);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyParzysta(4));
            Console.WriteLine("Koniec programu!");
        }
    }
}
