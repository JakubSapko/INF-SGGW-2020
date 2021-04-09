using System;

namespace Zad3
{
    class Operacje
    {
        public static int? Silnia(int n)
        {
            if ((n < 0) || (n > 12))
            {
                return null;
            }
            int w = 1;
            for(int i=1; i<n+1; i++)
            {
                w = w * i;
            }
            return w;
        }
        public static int? Pierwiastek(int n)
        {
            if (n < 0) { return null; }
            else { return (int)Math.Sqrt(n); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operacje.Silnia(0));
            Console.WriteLine(Operacje.Silnia(3));
            Console.WriteLine(Operacje.Silnia(12));
            Console.WriteLine(Operacje.Silnia(13));
            Console.WriteLine(Operacje.Silnia(-3));
            int? w = Operacje.Silnia(12);
            if (w.HasValue)
            {
                Console.WriteLine(w.Value);
            }
            else
            {
                Console.WriteLine("Dane niewlasciwe");
            }
            int? x = Operacje.Silnia(13);
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("Dane niewlasciwe");
            }
            int? z = Operacje.Pierwiastek(14);
            if (z.HasValue)
            {
                Console.WriteLine(z.Value);
            }
            else
            {
                Console.WriteLine("Dane niewlasciwe");
            }
            int? d = Operacje.Pierwiastek(-4);
            if (d.HasValue)
            {
                Console.WriteLine(d.Value);
            }
            else
            {
                Console.WriteLine("Dane niewlasciwe");
            }
        }
    }
}
