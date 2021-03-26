using System;

namespace Zad2
{
    abstract class Figura
    {
        string kolor;
        public Figura(string kolor)
        {
            this.kolor = kolor;
        }
        public abstract void Wyswietl();
        public abstract double Pole();
        public abstract double Obwod();
        public string Kolor
        {
            get => kolor;
        }
    }
    class Trojkat : Figura
    {
        double bok;
        public Trojkat(double bok, string kolor) : base(kolor)
        {
            this.bok = bok;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Trojkat o boku: " + bok + " i kolorze: " + Kolor);
        }
        public override double Obwod()
        {
            return 3 * bok;
        }
        public override double Pole()
        {
            return bok * bok * Math.Sqrt(3)/4;
        }
    }
    class Prostokat : Figura
    {
        double a;
        double b;
        public Prostokat(double a, double b, string kolor) : base(kolor)
        {
            this.a = a;
            this.b = b;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Prostokat o bokach: " + a + " i "  + b + " i kolorze: " + Kolor);
        }
        public override double Obwod()
        {
            return 2 * a + 2 * b;
        }
        public override double Pole()
        {
            return a*b;
        }
    }
    class Punkt : Figura
    {
        public Punkt(string kolor) : base(kolor) { }
        public override void Wyswietl()
        {
            Console.WriteLine("Punkt o kolorze: " + Kolor);
        }
        public override double Obwod()
        {
            return 0;
        }
        public override double Pole()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat T = new Trojkat(1, "czarny");
            Prostokat P = new Prostokat(3, 2, "niebieski");
            Punkt Pk = new Punkt("czerwony");
            Figura[] figury = { T, P, Pk };
            Wyswietlaj(figury);
        }
        static void Wyswietlaj(Figura[] figury)
        {
            foreach(Figura fig in figury)
            {
                Console.WriteLine("----------------");
                fig.Wyswietl();
                Console.WriteLine("Pole: " + fig.Pole());
                Console.WriteLine("Obwod: " + fig.Obwod());
                Console.WriteLine("----------------");
            }
        }
    }
}
