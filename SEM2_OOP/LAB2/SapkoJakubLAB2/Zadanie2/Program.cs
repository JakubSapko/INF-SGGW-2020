using System;

namespace Zadanie2
{
    struct Punkt
    {
        double x, y;
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
    }

    struct Prostokat
    {
        Punkt p1, p2;
        public Prostokat(double x1, double x2, double y1, double y2)
        {
            p1 = new Punkt(Math.Min(x1, x2), Math.Min(y1, y2));
            p2 = new Punkt(Math.Max(x1, x2), Math.Max(y1, y2));
        }
        public Prostokat(Punkt p1, Punkt p2) : this(p1.X, p2.X, p1.Y, p2.Y) { }
        public void Wyswietl()
        {
            Console.WriteLine("prostokat [{0};{1}] [{2};{3}]", p1.X, p1.Y, p2.X, p2.Y);
        }
        public double Podstawa
        {
            get { return p2.X - p1.X; }

        }
        public double Wysokosc
        {
            get { return p2.Y - p1.Y; }
        }
        public double Pole()
        {
            return Podstawa * Wysokosc;
        }
        public double Obwod()
        {
            return 2 * Podstawa + 2 * Wysokosc;
        }

        public static Prostokat Obejmujacy(Prostokat r1, Prostokat r2)
        {
            double x1 = Math.Min(r1.p1.X, r2.p1.X);
            double x2 = Math.Max(r1.p2.X, r2.p2.X);
            double y1 = Math.Min(r1.p1.Y, r2.p1.Y);
            double y2 = Math.Max(r1.p2.Y, r2.p2.Y);
            return new Prostokat(x1, x2, y1, y2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat r1 = new Prostokat(0, 2, 1, 4);
            r1.Wyswietl();
            Console.WriteLine(r1.Pole());
            Prostokat r2 = new Prostokat(2, 3, 3, 3);
            Prostokat.Obejmujacy(r1, r2).Wyswietl();
        }
    }
}
