using System;

namespace RunCode
{
    class Program
    {
        static bool CzyDuzaLitera(char znak)
        {
            // tu dodaj swój kod
            if (znak>='A' && znak <= 'Z') { return true; }
            else { return false;  }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyDuzaLitera('B'));
            Console.WriteLine(CzyDuzaLitera('H'));
            Console.WriteLine(CzyDuzaLitera('c'));
            Console.WriteLine("Koniec programu!");
        }
    }
}
