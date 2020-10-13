using System;

namespace RunCode
{
    class Program
    {
        static int IleZnakowWTekscie(string tekst)
        {
            // tu dodaj swój kod
            return tekst.Length;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(IleZnakowWTekscie("dupa"));
            Console.WriteLine("Koniec programu!");
        }
    }
}
