using System;

namespace RunCode
{
    class Program
    {
        static int IlePierwiastkow(double delta)
        {
            // tu dodaj swój kod
            if (delta > 0) { return 2; }
            else if (delta == 0) { return 1; }
            else { return 0; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(IlePierwiastkow(2));
            Console.WriteLine(IlePierwiastkow(0));
            Console.WriteLine(IlePierwiastkow(-4));
            Console.WriteLine("Koniec programu!");
        }
    }
}
