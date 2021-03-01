using System;

namespace Z1
{
    class Węzeł
    {
        public int dane;
        public int counter = 1;

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

            if (liczba == korzeń.dane)
            {
                korzeń.counter++;
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
        public bool search(Węzeł korzeń, int klucz)
        {
            while (korzeń != null)
            {
                if (klucz > korzeń.dane) { korzeń = korzeń.prawy; }
                else if (klucz < korzeń.dane) { korzeń = korzeń.lewy; }
                else { return true; }
            }
            return false;
        }
        public void wypisz(Węzeł korzeń, int spacja)
        {
            if (korzeń == null) return;
            spacja += 10;
            wypisz(korzeń.prawy, spacja);
            Console.Write("\n");
            for(int i = 10; i < spacja; i++)
            {
                Console.Write(" ");
            }
            Console.Write(korzeń.dane + "(" + korzeń.counter + ")" + "\n");
            wypisz(korzeń.lewy, spacja);

        }
        public void deleteKey(int klucz) { korzeń = delete(korzeń, klucz); }
        int minValue(Węzeł korzeń)
        {
            int minv = korzeń.dane;
            while(korzeń.lewy != null)
            {
                minv = korzeń.lewy.dane;
                korzeń = korzeń.lewy;
            }
            return minv;
        }
        public Węzeł delete(Węzeł korzeń, int klucz)
        {
            if (korzeń == null) return korzeń;
            if (klucz < korzeń.dane) korzeń.lewy = delete(korzeń.lewy, klucz);
            else if (klucz > korzeń.dane) korzeń.prawy = delete(korzeń.prawy, klucz);
            else
            {
                if(korzeń.counter > 1)
                {
                    korzeń.counter--;
                    return korzeń;
                }
                if (korzeń.lewy == null) return korzeń.prawy;
                else if (korzeń.prawy == null) return korzeń.lewy;
                korzeń.dane = minValue(korzeń.prawy);
                korzeń.prawy = delete(korzeń.prawy, korzeń.dane);
            }
            return korzeń;
        }
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
                d.Dodaj(8);
            d.Dodaj(8);
            d.wypisz(d.korzeń, 1);
                Console.ReadKey();
            }
        }
    }
