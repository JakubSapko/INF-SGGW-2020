using System;

namespace Zad5
{
    class ZbiorOpisow
    {
        Zapis start;
        public void DodajZapis(string s)
        {
            if (start == null)
            {
                start = new Zapis(s);
            }
            else
            {
                start.Dodaj(s);
            }
        }
        public void Wyswietl()
        {
            if(start == null)
            {
                Console.WriteLine("Brak zapisow");
            }
            else
            {
                start.Wyswietl();
            }
        }
        class Zapis
        {
            string zapis;
            Zapis nastepny;
            public Zapis(string zapis)
            {
                this.zapis = zapis;
            }
            public void Dodaj(string s)
            {
                Zapis z = new Zapis(s);
                Zapis tmp = this;
                while(tmp.nastepny != null)
                {
                    tmp = tmp.nastepny;
                }
                tmp.nastepny = z;
            }
            public void Wyswietl()
            {
                Zapis tmp = this;
                while (tmp != null)
                {
                    Console.WriteLine(tmp.zapis);
                    tmp = tmp.nastepny;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ZbiorOpisow zo = new ZbiorOpisow();
            zo.Wyswietl();
            zo.DodajZapis("Poczatek zajec");
            zo.DodajZapis("Zadanie 1");
            zo.DodajZapis("Koniec zajec");
            zo.Wyswietl();
        }
    }
}
