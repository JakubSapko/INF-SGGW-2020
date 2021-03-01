using System;

namespace Zadanie1
{
    //Class approach
    public class Punkt
    {
        public double x;
        public double y;
        public Punkt(double x, double y)
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
        public void Edit(double nx, double ny)
        {
            x = nx;
            y = ny;
        }
    }
    //struct approach
    public struct PunktP
    {
        public double x;
        public double y;
        public PunktP(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void WypiszWsp()
        {
            Console.WriteLine("Współrzędna x danego punktu wynosi: {0}, a współrzędna y: {1}", x, y);
        }
        public double Dist(PunktP P)
        {
            return Math.Sqrt(Math.Pow((x - P.x), 2) + Math.Pow((y - P.y), 2));
        }
        public void Edit(double nx, double ny)
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
            PunktP W = new PunktP(5, 3);
            PunktP Z = new PunktP(0, 0);
            W.WypiszWsp();
            Z.WypiszWsp();
            Console.WriteLine(W.Dist(Z));
            Console.WriteLine(Z.Dist(W));
            W.Edit(2, 2);
            W.WypiszWsp();
        }
    }
}
