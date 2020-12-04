using System;

namespace Z1
{
    class Węzeł
    {
        public int dane; 

        public Węzeł lewy; 
        public Węzeł prawy;

    }
    class Drzewo
    {
        public Węzeł korzeń;

        public void Dodaj(int liczba)
        {
            Węzeł w = new Węzeł(); 
            w.dane = liczba; 

            if (korzeń == null) 
            {
                korzeń = w;
                return; 
            }


            Węzeł aktualny; 
            Węzeł ojciec; 

            aktualny = korzeń; 
            ojciec = korzeń; 

            while (aktualny != null)
            {
                ojciec = aktualny; 
                if (aktualny.dane > liczba)
                {
                    aktualny = aktualny.lewy;
                }
                else
                {
                    aktualny = aktualny.prawy;
                }
            }
            if (ojciec.dane > liczba)
            {
                ojciec.lewy = w;
            }
            else
            {
                ojciec.prawy = w;
            }
        }
        public Węzeł search(Węzeł korzeń, int klucz)
        {
            if (korzeń == null || korzeń.dane == klucz) { return korzeń; }
            if (korzeń.dane < klucz) { return search(korzeń.prawy, klucz); }
            return search(korzeń.lewy, klucz);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Drzewo d = new Drzewo();
            d.Dodaj(5);
            d.Dodaj(3);
            d.Dodaj(6);
            d.Dodaj(1);
            d.Dodaj(4);
            Console.WriteLine(d.search(d.korzeń, 3));
            Console.ReadKey();
        }
    }
}
