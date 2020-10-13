using System;

namespace RunCode
{
    class Program
    {
        static char ZnakPoprzedzajacy(char c, int ile)
        {
            // tu dodaj swój kod
            return Convert.ToChar(c - ile);
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(ZnakPoprzedzajacy('d', 3));
            Console.WriteLine("Koniec programu!");
        }
    }
}
