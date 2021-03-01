using System;

namespace RunCode
{
    class Program
    {
        static double ZwrocPolowe(int x)
        {
            // dodaj kod tej funkcji
            return Convert.ToDouble(x) / 2;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            ZwrocPolowe(5);
            Console.WriteLine("Koniec programu!");
        }
    }
}
