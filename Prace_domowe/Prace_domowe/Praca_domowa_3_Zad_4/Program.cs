using System;

namespace Praca_domowa_3_Zad_4
{
    class Program
    {
        static double Delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        
        static int IlePierwiastkow(double delta)
        {
            if (delta > 0) { return 2; }
            else if (delta == 0) { return 1; }
            else { return 0; }
        }
        static string Sgn(double w)
        {
            if (w > 0) { return "+"; }
            else if (w < 0) { return "-"; }
            else { return ""; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program równania kwadratowego");
            Console.WriteLine("Podaj współczynniki równania kwadratowego");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                if (x == 0) { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x{1}{2}=0", y, Sgn(z), Math.Abs(z)); }
                else if (y == 0) { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x^2{1}{2}=0", x, Sgn(z), Math.Abs(z)); }
                else if (z == 0) { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x^2{1}{2}*x=0", x, Sgn(y), Math.Abs(y)); }
                else if (x == 0 && y == 0) { Console.WriteLine("Toż to nie równanie"); }
                else if (x == 0 && z == 0) { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x=0", y); }
                else if (y == 0 && z == 0) { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x^2=0", x); }
                else { Console.WriteLine("Równanie kwadratowe jest postaci: {0}*x^2{1}{2}*x{3}{4}=0", x, Sgn(y), Math.Abs(y), Sgn(z), Math.Abs(z)); }
                Console.WriteLine("Delta tego równania wynosi: {0}", Delta(x, y, z));
                Console.WriteLine("To równanie ma {0} piertwiastków", IlePierwiastkow(Delta(x, y, z)));
                if (Delta(x, y, z) > 0) { Console.WriteLine("Pierwiastki tego równania to: {0} oraz {1}", (-y + Math.Sqrt(Delta(x, y, z)) / (2 * x)), (-y - Math.Sqrt(Delta(x, y, z)) / (2 * x))); }
                else if (Delta(x, y, z) == 0) { Console.WriteLine("Pierwiastek tego równania to: {0}", -y / (2 * x)); }
                else { Console.WriteLine("To równanie nie ma pierwiastków"); }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Złe dane");
            }
        }
    }
}
