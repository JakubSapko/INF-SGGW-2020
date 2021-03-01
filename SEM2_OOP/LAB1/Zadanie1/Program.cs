using System;

namespace Zadanie1
{
    //Podejscie dla klasy
    public class Punkt
    {
        public int x;
        public int y;
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void WypiszWsp()
        {
            Console.WriteLine("Współrzędna x danego punktu wynosi: {0}, a współrzędna y: {1}", x, y);
        }
        public double Dist(Punkt P)
        {
            return Math.Sqrt(Math.Pow((x - P.x), 2) + Math.Pow((y - P.y), 2));
        }
        public void Edit(int nx, int ny)
        {
            x = nx;
            y = ny;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt P = new Punkt(5, 3);
            Punkt X = new Punkt(0, 0);
            P.WypiszWsp();
            X.WypiszWsp();
            Console.WriteLine(P.Dist(X));
            Console.WriteLine(X.Dist(P));
            P.Edit(2, 2);
            P.WypiszWsp();
        }
    }
}
