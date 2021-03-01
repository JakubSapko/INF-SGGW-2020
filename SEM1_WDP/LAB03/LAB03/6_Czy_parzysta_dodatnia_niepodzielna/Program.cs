using System;

namespace RunCode
{
    class Program
    {
        static bool CzyParzIDodINPrzez3(int liczba)
        {
            // tu dodaj swój kod
            if(liczba%2==0 && liczba>0 && liczba % 3 != 0) { return true;  }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyParzIDodINPrzez3(6));
            Console.WriteLine(CzyParzIDodINPrzez3(2));
            Console.WriteLine(CzyParzIDodINPrzez3(-4));
            Console.WriteLine(CzyParzIDodINPrzez3(-6));
            Console.WriteLine("Koniec programu!");
        }
    }
}
