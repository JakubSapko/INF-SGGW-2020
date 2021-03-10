using System;

namespace Zadanie1
{
    class Program
    {
        struct Zespolona
        {
            double x;
            double y;

            public Zespolona(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void Wyswietl()
            {
                Console.WriteLine("("+x+";"+y+")");
            }
            /*public void Dodaj(Zespolona z)
            {
                x = x + z.x;
                y = y + z.y;
            }*/
            public Zespolona Dodaj(Zespolona z)
            {
                return new Zespolona(
                x + z.x,
                y + z.y);
            }
            public static Zespolona Dodaj(Zespolona z, Zespolona w)
            {
                return new Zespolona(
                w.x + z.x,
                w.y + z.y);
            }
            public void Odejmij(Zespolona z)
            {
                x = x - z.x;
                y = y - z.y;
            }

            public void Pomnoz(Zespolona z)
            {
                double old_x = z.x, old_y = z.y, old_X = x, old_Y = y;
                x = x * z.x - y * z.y;
                y = old_X * old_y + old_x * old_Y;
            }
            public static Zespolona Pomnoz(Zespolona z, Zespolona w)
            {
                
                double x = w.x * z.x - w.y * z.y;
                double y = z.x * w.y + z.y * w.x;
                return new Zespolona(x, y);
            }
            public void Podziel(Zespolona z)
            {
                double old_x = z.x, old_y = z.y, old_X = x, old_Y = y;
                double dzielnik = (z.y * z.y + z.x * z.x);
                x = (x * z.x + y * z.y) / dzielnik;
                y = (old_Y * old_x - old_X * old_y) / dzielnik;
            }

            public double Re
            {
                get
                {
                    return x;
                }
            }
            public double Im
            {
                get
                {
                    return y;
                }
            }
            public double modul
            {
                get
                {
                    return Math.Sqrt(x * x + y * y);
                }
            }
            public Zespolona Sprzezona()
            {
                return new Zespolona(x, -y);
            }
        }
        static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(7, 5);
            Zespolona z2 = new Zespolona(2, 1);
            Zespolona z = z1.Dodaj(z2);
            z.Wyswietl();
            z = Zespolona.Dodaj(z1, z2);
            z.Wyswietl();
            z = Zespolona.Dodaj(z2, z1);
            z.Wyswietl();
            z = Zespolona.Pomnoz(z1, z2);
            z.Wyswietl();
            Console.WriteLine(z.Re);
            z.Sprzezona().Wyswietl();
        }
    }
}
