using System;

namespace RunCode
{
    class Program
    {
        static string ZwrocBinarnie(long liczba)
        {
            string zwrot = "";
            do
            {
                zwrot = (liczba % 2) + zwrot;
                liczba /= 2;
            } while (liczba > 0);
            return zwrot;
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
