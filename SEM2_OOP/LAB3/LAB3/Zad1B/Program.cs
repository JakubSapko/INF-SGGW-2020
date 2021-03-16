using System;

namespace zad2
{
    struct Punkt
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Przesun(double d, double f)
        {
            x += d;
            y += f;
        }
        public void Wyswietl()
        {
            Console.WriteLine(x + " " + y);
        }

        // niestatyczne
        public double Odleglosc(Punkt p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }

        public bool CzyIdentyczny(Punkt p)
        {
            return (x == p.x) && (y == p.y);
        }

        // statyczne, wykorzystujace juz zdefiniowane metody zwykle
        public static double Odleglosc(Punkt p1, Punkt p2)
        {
            return p1.Odleglosc(p2);
        }

        public static bool CzyIdentyczne(Punkt p, Punkt q)
        {
            return q.CzyIdentyczny(p);
        }
    }

    struct PunktKolorowy
    {
        Punkt p;
        string kolor;

        public PunktKolorowy(double x, double y, string kolor)
        {
            this.p = new Punkt(x, y);
            this.kolor = kolor;
        }

        public void Wyswietl()
        {
            Console.WriteLine(kolor);
            p.Wyswietl();
        }

        public double Odleglosc(Punkt po)
        {
            return p.Odleglosc(po);
        }

        public double Odleglosc(PunktKolorowy po)
        {
            return p.Odleglosc(po.p);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(1, 2);
            p1.Wyswietl();
            PunktKolorowy pc = new PunktKolorowy(2, 3, "zielony");
            pc.Wyswietl();
            Console.WriteLine(pc.Odleglosc(p1));

            PunktKolorowy pc2 = new PunktKolorowy(1, 1, "czarny");
            pc2.Wyswietl();

            Console.WriteLine(pc2.Odleglosc(pc));
        }
    }
}