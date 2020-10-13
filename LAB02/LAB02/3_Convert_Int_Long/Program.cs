using System;

namespace RunCode
{
    class Program
    {
        static long Dodaj(int a, int b)
        {
            long wynik = Convert.ToInt64(a) + Convert.ToInt64(b);
            return wynik;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Dodaj(1000000000, 2000000000);
            Console.WriteLine(Dodaj(1000000000, 2000000000));
            Console.WriteLine("Koniec programu!");
        }
    }
}
