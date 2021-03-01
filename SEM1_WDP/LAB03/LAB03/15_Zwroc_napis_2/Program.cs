using System;

namespace RunCode
{
    class Program
    {
        static string ZwrocNapis2(string tekst1, string tekst2)
        {
            // tu dodaj swój kod
            if (tekst2.Length < 0.5 * tekst1.Length) { return tekst1 + tekst2; }
            else { return tekst1; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(ZwrocNapis2("babcia", "ma"));
            Console.WriteLine(ZwrocNapis2("babcia", "dziadek"));
            Console.WriteLine("Koniec programu!");
        }
    }
}
