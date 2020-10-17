using System;

namespace RunCode
{
    class Program
    {
        static bool CzyParzystaIDodatania(int liczba)
        {
            // tu dodaj swój kod
            if (liczba>0 && liczba % 2 == 0) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyParzystaIDodatania(6));
            Console.WriteLine(CzyParzystaIDodatania(5));
            Console.WriteLine(CzyParzystaIDodatania(-8));
            Console.WriteLine("Koniec programu!");
        }
    }
}
