using System;

namespace RunCode
{
    class Program
    {
        static bool Zaprzecz(bool b)
        {
            // dodaj kod tej funkcji
            return !b;
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Zaprzecz(true);
            Console.WriteLine("Koniec programu!");
        }
    }
}
