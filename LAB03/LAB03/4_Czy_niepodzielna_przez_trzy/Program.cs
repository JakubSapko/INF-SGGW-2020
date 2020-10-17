using System;

namespace RunCode
{
    class Program
    {
        static bool CzyNiepodzielnaPrzez3(int liczba)
        {
            // tu dodaj swój kod
            if (liczba % 3 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyNiepodzielnaPrzez3(3));
            Console.WriteLine(CzyNiepodzielnaPrzez3(27));
            Console.WriteLine(CzyNiepodzielnaPrzez3(4));
            Console.WriteLine("Koniec programu!");
        }
    }
}
