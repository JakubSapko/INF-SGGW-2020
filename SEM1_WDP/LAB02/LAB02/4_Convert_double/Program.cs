using System;

namespace RunCode
{
    class Program
    {
        static double Podziel(int x, int y)
        {
            double wynik = Convert.ToDouble(x) / Convert.ToDouble(y);
            return wynik;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Podziel(3, 5);
            Console.WriteLine("Koniec programu!");
        }
    }
}
