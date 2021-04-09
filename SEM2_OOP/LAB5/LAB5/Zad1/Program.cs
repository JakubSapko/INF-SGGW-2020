using System;

namespace Zad1
{
    class Tablica
    {
        private double[] tablica;
        // mozna definiować tak
        // private double[] tablica = new double[20];
        public Tablica(uint rozmiar)
        {
            tablica = new double[rozmiar];
        }
        public void Wypisz()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("{0}  ", tablica[i]);
            }
            Console.WriteLine();
        }
        public double this[int i]
        {
            get
            {
                if(i>=1 && i < tablica.Length)
                {
                    return tablica[i - 1];
                }
                else
                {
                    return double.NaN;
                }
            }
            set
            {
                tablica[i] = value;
            }
        }
        public int Rozmiar
        {
            get => tablica.Length;
        }
        public double suma()
        {
            double s = 0;
            for(int i = 0; i<Rozmiar; i++)
            {
                s += tablica[i];
            }
            return s;
        }
        public bool zawiera(double x)
        {
            for(int i = 0; i<Rozmiar; i++)
            {
                if (tablica[i] == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tablica t = new Tablica(3);
            t.Wypisz();
            for(int i = 0; i<t.Rozmiar; i++)
            {
                t[i] = 1.3 * i;
            }
            t.Wypisz();
            Console.WriteLine(t.suma());
            Console.WriteLine(t.zawiera(1.3));
        }
    }
}
