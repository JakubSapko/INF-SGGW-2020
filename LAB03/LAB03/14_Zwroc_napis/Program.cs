using System;

namespace RunCode
{
    class Program
    {
        static string ZwrocNapis1(string tekst, char znak)
        {
            // tu dodaj swój kod
            if (tekst.Length %2 == 0) { return Convert.ToString(znak); }
            else { return tekst + znak; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocNapis1("mama", 'r'));
            Console.WriteLine(ZwrocNapis1("kajak", 'i'));
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine("Koniec programu!");
        }
    }
}
