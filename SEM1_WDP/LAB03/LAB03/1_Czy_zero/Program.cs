using System;

namespace RunCode
{
    class Program
    {
        static bool CzyZero(int a)
        {
            // tu dodaj swój kod
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyZero(0));
            Console.WriteLine(CzyZero(1));
            Console.WriteLine("Koniec programu!");
        }
    }
}
