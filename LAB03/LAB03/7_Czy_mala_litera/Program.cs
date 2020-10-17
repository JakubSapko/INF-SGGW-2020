using System;

namespace RunCode
{
    class Program
    {
        static bool CzyMalaLitera(char znak)
        {
            // tu dodaj swój kod
            if (znak>='a' && znak <= 'z') { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyMalaLitera('v'));
            Console.WriteLine(CzyMalaLitera('C'));
            Console.WriteLine("Koniec programu!");
        }
    }
}
