using System;

namespace RunCode
{
    class Program
    {
        static bool CzyTakieSame(string tekst1, string tekst2)
        {
            // tu dodaj swój kod
            return (tekst1 == tekst2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyTakieSame("pies", "pies"));
            Console.WriteLine(CzyTakieSame("pies", "kot"));
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
        }
    }
}
