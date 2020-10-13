using System;

namespace RunCode
{
    class Program
    {
        static double ZwrocCwiartke(int x)
        {
            // dodaj kod tej funkcji
            return Convert.ToDouble(x) / 4;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            ZwrocCwiartke(10);
            Console.WriteLine("Koniec programu!");
        }
    }
}
