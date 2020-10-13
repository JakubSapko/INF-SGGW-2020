using System;

namespace RunCode
{
    class Program
    {
        static int Dodaj(long a, long b)
        {
            // dokonaj konwersji
            int wynik = Convert.ToInt32(a) + Convert.ToInt32(b);
            return wynik;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Dodaj(5, 3);
            Console.WriteLine(Dodaj(5, 3));
            Console.WriteLine("Koniec programu!");
        }
    }
}
