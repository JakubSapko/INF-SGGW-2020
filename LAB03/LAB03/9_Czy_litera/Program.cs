using System;

namespace RunCode
{
    class Program
    {
        static bool CzyLitera(char znak)
        {
            // tu dodaj swój kod
            if ((znak >= 'a' && znak <= 'z' )||( znak >= 'A' && znak <= 'Z')) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyLitera('b'));
            Console.WriteLine(CzyLitera('H'));
            Console.WriteLine(CzyLitera('/'));
            Console.WriteLine("Koniec programu!");
        }
    }
}
