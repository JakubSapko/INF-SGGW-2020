using System;

namespace Zadanie4
{
    public class Zespolona
    {
        public double x;
        public double y;

        public Zespolona(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Wyswietl()
        {
            Console.WriteLine(x + "+" + y + "i");
        }
        public void Dodaj(Zespolona z)
        {
            x = x + z.x;
            y = y + z.y;
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
        public void Podziel(Zespolona z)
        {
            double old_x = z.x, old_y = z.y, old_X = x, old_Y = y;
            double dzielnik = (z.y * z.y + z.x * z.x);
            x = (x * z.x + y * z.y) / dzielnik;
            y = (old_Y * old_x - old_X * old_y) / dzielnik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zespolona z = new Zespolona(2, 2);
            Zespolona x = new Zespolona(3, 4);
            z.Wyswietl();
            x.Wyswietl();
            //z.Dodaj(x);
            //z.Wyswietl();
            //z.Pomnoz(x);
            z.Podziel(x);
            z.Wyswietl();
        }
    }
}
