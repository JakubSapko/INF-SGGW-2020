using System;

namespace RunCode
{
    class Program
    {
        static bool CzyNalezyDoKola(double X1, double Y1, double Xs, double Ys, double r)
        {
            // tu dodaj swój kod
            double odl = Math.Sqrt(Math.Pow((X1 - Xs), 2) + Math.Pow((Y1 - Ys), 2));
            if (odl <= r) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyNalezyDoKola(4.0, 1.0, 2.0, 2.0, 3));
            Console.WriteLine(CzyNalezyDoKola(6.0, 2.0, 2.0, 2.0, 3));
            Console.WriteLine(CzyNalezyDoKola(-2.0, 0, 2.0, 2.0, 3));
            Console.WriteLine("Koniec programu!");
        }
    }
}
