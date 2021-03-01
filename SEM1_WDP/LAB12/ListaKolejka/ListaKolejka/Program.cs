using System;
using System.IO;

namespace ListaKlientów
{
    public enum TypPłatności { Gotówka, Karta, BonTowarowy };

    public class Klient
    {
        string nazwisko;
        int liczbaProduktów;
        TypPłatności typPłatności;
        double doZapłaty;
        public Klient(string nazwisko, int liczbaProduktów, TypPłatności typPłatności, double doZapłaty)
        {
            this.nazwisko = nazwisko;
            this.liczbaProduktów = liczbaProduktów;
            this.typPłatności = typPłatności;
            this.doZapłaty = doZapłaty;
        }
        public string ZwrocDane()
        {
            return nazwisko + " " + liczbaProduktów + " " + typPłatności + " " + doZapłaty;
        }
    }

    public class Kolejka
    {

        public class Węzeł
        {
            public Klient klient;
            public Węzeł następny;
        }

        public Węzeł głowa;
        public Węzeł ogon;

        public bool CzyPusta()
        {
            return głowa == null;
        }

        public void DodajDoGłowy(Klient k)
        {
            Węzeł tmp = new Węzeł();
            tmp.klient = k;
            // dodany element staje się głową, więc dotychczasowa głowa staje się obiektem, który jest "następny"
            tmp.następny = głowa;
            // dodany element staje się głową
            głowa = tmp;
            // jeśli uprzednio lista była pusta, ogon i głowa wskazują na ten sam element
            if (ogon == null)
                ogon = tmp;
        }

        public void DodajDoOgona(Klient k)
        {
            Węzeł tmp = new Węzeł();
            tmp.klient = k;
            if (ogon == null)
            {
                // lista jest pusta, więc ogon ma tę samą wartość, co głowa
                ogon = głowa = tmp;
            }
            else
            {
                ogon.następny = tmp;
                ogon = tmp;
            }
        }

        public int ZwróćRozmiar()
        {
            int licznik = 0;
            for (Węzeł tmp = głowa; tmp != null; tmp = tmp.następny)
            {
                licznik++;
            }
            return licznik;
        }

        public void Zapisz(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            Węzeł x;
            x = głowa;
            while (x != null)
            {
                sw.WriteLine(x.klient.ZwrocDane());
                x = x.następny;
            }
            sw.Close();
        }
        Klient OdczytKlient(StreamReader sr)
        {
            if (sr.EndOfStream) { return null; }
            else
            {
                string linia = sr.ReadLine();
                int i = 0;
                string nazwisko = "",
                       liczbaProd = "" ,
                       typPłatności = "",
                       doZapłaty = "";
                while(linia[i]!=' ')
                {
                    nazwisko += linia[i];
                    i++;
                }
                i++;
                while (linia[i] != ' ')
                {
                    liczbaProd += linia[i];
                    i++;
                }
                i++;
                while (linia[i] != ' ')
                {
                    typPłatności += linia[i];
                    i++;
                }
                i++;
                while (linia[i] != ' ')
                {
                    doZapłaty += linia[i];
                    i++;
                }
                TypPłatności x = TypPłatności.Gotówka;
                if (typPłatności == "BonTowarowy")
                {
                    x = TypPłatności.BonTowarowy;
                }
                if (typPłatności == "Gotówka")
                {
                    x = TypPłatności.Gotówka;
                }
                if (typPłatności == "Karta")
                {
                    x = TypPłatności.Karta;
                }
                Klient odczyt = new Klient(nazwisko, Convert.ToInt32(liczbaProd), x, Convert.ToDouble(doZapłaty));
                return odczyt;
            }
        }
        public void Wyświetl()
        {
            for (Węzeł tmp = głowa; tmp != null; tmp = tmp.następny)
            {
                Console.WriteLine(tmp.klient.ZwrocDane());
            }

        }
        public void Odczytaj(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                DodajDoGłowy(OdczytKlient(sr));
            }
        }
        public void Odwróć()
        {
            // metoda odwracająca kolejność elementów na liście
            Węzeł tmp = głowa;
            Węzeł tmp2;
            while (tmp.następny != null)
            {
                tmp2 = tmp.następny;
                tmp.następny = tmp2.następny;
                tmp2.następny = głowa;
                głowa = tmp2;
            }
        }
        public Klient UsuńZGłowy()
        {
            Klient tmp;
            if (głowa != null) // sprawdzamy, czy lista nie jest pusta
            {
                tmp = głowa.klient;
                // sprawdzamy, czy na liście jest jeden element
                if (głowa == ogon)
                    głowa = ogon = null; // lista teraz jest pusta
                else
                    głowa = głowa.następny;
                return tmp;
            }
            else
                throw new Exception("Lista pusta!");
        }

        public Klient UsuńZOgona()
        {
            if (ogon == null)
                throw new Exception("Lista jest pusta");
            Klient tmp = ogon.klient;

            if (głowa == ogon)
                głowa = ogon = null;
            else
            {
                Węzeł wezel;
                // w pętli przejdziemy ze zmienną wezel o jeden element przed ogon
                for (wezel = głowa; wezel.następny != ogon; wezel = wezel.następny) ;
                // zmienna wezel należy ustawić jako nowy ogon
                ogon = wezel;
                // i wyczyścić jego następcę
                ogon.następny = null;
            }
            return tmp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka mojaLista = new Kolejka();
            Klient a = new Klient("Sapko", 1, TypPłatności.BonTowarowy, 10);
            Klient b = new Klient("Nowak", 1, TypPłatności.BonTowarowy, 10);
            Klient c = new Klient("Kowalski", 1, TypPłatności.BonTowarowy, 10);
            Klient d = new Klient("Dupa", 1, TypPłatności.BonTowarowy, 10);
            mojaLista.DodajDoGłowy(a);
            mojaLista.DodajDoGłowy(b);
            mojaLista.DodajDoGłowy(c);
            mojaLista.DodajDoGłowy(d);

            mojaLista.Zapisz("dupsko.txt");
        }
    }
}
