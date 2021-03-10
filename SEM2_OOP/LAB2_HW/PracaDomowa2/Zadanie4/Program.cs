using System;

namespace Zadanie4
{
    class Macierz
    {
        double a11, a12, a21, a22;
        public Macierz(double x, double y, double z, double w)
        {
            a11 = x;
            a12 = y;
            a21 = z;
            a22 = w;
        }

        public static void PomnozPrzezStala(Macierz m, double con)
        {
            m.a11 = m.a11 * con;
            m.a12 = m.a12 * con;
            m.a21 = m.a21 * con;
            m.a22 = m.a22 * con;
        }
        public static Macierz DodajMacierze(Macierz m, Macierz w)
        {
            double x11, x12, x21, x22;
            x11 = m.a11 + w.a11;
            x12 = m.a12 + w.a12;
            x21 = m.a21 + w.a21;
            x22 = m.a22 + w.a22;
            return new Macierz(x11, x12, x21, x22);
        }
        public static Macierz PomnozMacierze(Macierz m, Macierz w)
        {
            double x11, x12, x21, x22;
            x11 = m.a11 * w.a11 + m.a12 * w.a21;
            x12 = m.a11 * w.a12 + m.a12 * w.a22;
            x21 = m.a21 * w.a11 + m.a22 * w.a21;
            x22 = m.a21 * w.a12 + m.a22 * w.a22;
            return new Macierz(x11, x12, x21, x22);
        }
        public static void OdwrocMacierz(Macierz m)
        {
            double od_det = 1 / (m.a11 * m.a22 - m.a12 * m.a21);
            double bufor = m.a22;
            m.a22 = m.a11;
            m.a11 = bufor;
            m.a12 *= -1;
            m.a21 *= -1;
            m.a11 *= od_det;
            m.a12 *= od_det;
            m.a21 *= od_det;
            m.a22 *= od_det;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Macierz:");
            Console.WriteLine("[{0};{1}]", a11, a12);
            Console.WriteLine("[{0};{1}]", a21, a22);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Macierz m = new Macierz(1, 2, 3, 4);
            m.Wyswietl();
            Macierz w = new Macierz(2, 4, 6, 8);
            w.Wyswietl();
            Macierz.DodajMacierze(m, w).Wyswietl();
            Macierz.PomnozMacierze(m, w).Wyswietl();
            Macierz.OdwrocMacierz(m);
            m.Wyswietl();
        }
    }
}
