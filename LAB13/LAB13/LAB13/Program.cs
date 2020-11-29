using System;
using System.IO;

namespace ListaKlientów
{
    public enum TypPłatności { Gotówka, Karta, BonTowarowy };

    public class Klient
    {
        public string nazwisko;
        public int liczbaProduktów;
        public TypPłatności typPłatności;
        public double doZapłaty;
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
                       liczbaProd = "",
                       typPłatności = "",
                       doZapłaty = "";
                while (linia[i] != ' ')
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

        public int Wyszukaj(string nazwisko)
        {
            Węzeł tmp = głowa;
            int counter = -1;
            for(int i = 0; i<ZwróćRozmiar(); i++)
            {
                if(głowa.klient.nazwisko == nazwisko)
                {
                    counter = i;
                }
                tmp = tmp.następny;
            }
            return counter;
        }
        public void Zamień(string nazwisko1, string nazwisko2)
        {
            //Przypdek gdy to ta sama/nierozróżnialna osoba
            if (nazwisko1 == nazwisko2) { return; }
            Węzeł prevX = null, currX = głowa;
            while (currX != null && currX.klient.nazwisko != nazwisko1)
            {
                prevX = currX;
                currX = currX.następny;
            }
            Węzeł prevY = null, currY = głowa;
            while (currY != null && currY.klient.nazwisko != nazwisko2)
            {
                prevY = currY;
                currY = currY.następny;
            }
            if(currX == null || currY == null)
            {
                return;
            }
            if (prevX != null)
            {
                prevX.następny = currY;
            }
            else
            {
                głowa = currY;
            }
            if (prevY != null)
            {
                prevY.następny = currX;
            }
            else
            {
                głowa = currX;
            }
            Węzeł temp = currX.następny;
            currX.następny = currY.następny;
            currY.następny = temp;
        }
        public void Wstaw(Klient k, int indeks)
        {
            Węzeł temp = new Węzeł();
            temp.klient = k;
            temp.następny = null;
            if(głowa == null)
            {
                if (indeks != 0)
                {
                    return;
                }
                else
                {
                    głowa = temp;
                }
            }
            if(głowa!=null && indeks == 0)
            {
                temp.następny = głowa;
                głowa = temp;
                return;
            }
            Węzeł cur = głowa;
            Węzeł pre = null;
            int i = 0;
            while (i < indeks)
            {
                pre = cur;
                cur = cur.następny;
                if(cur == null)
                {
                    break;
                }
                i++;
            }
            temp.następny = cur;
            pre.następny = temp;
        }
        public int Maksimum()
        {
            Węzeł tmp = głowa;
            double maks = głowa.klient.doZapłaty;
            int indeks = Wyszukaj(głowa.klient.nazwisko);
            for(int i = 0; i<ZwróćRozmiar(); i++)
            {
                tmp = tmp.następny;
                if (tmp.klient.doZapłaty > maks)
                {
                    maks = tmp.klient.doZapłaty;
                    indeks = Wyszukaj(tmp.klient.nazwisko);
                }
            }
            return indeks;
        }
        public int Minimum()
        {
            Węzeł tmp = głowa;
            double min = głowa.klient.doZapłaty;
            int indeks = Wyszukaj(głowa.klient.nazwisko);
            for (int i = 0; i < ZwróćRozmiar(); i++)
            {
                tmp = tmp.następny;
                if (tmp.klient.doZapłaty < min)
                {
                    min = tmp.klient.doZapłaty;
                    indeks = Wyszukaj(tmp.klient.nazwisko);
                }
            }
            return indeks;
        }
        public void Sort()
        {
            Węzeł cur = głowa, index = null;
            Klient temp;
            if (głowa == null)
            {
                return;
            }
            else
            {
                while (cur != null)
                {
                    index = cur.następny;
                    while (index != null)
                    {
                        if (cur.klient.doZapłaty > index.klient.doZapłaty)
                        {
                            temp = cur.klient;
                            cur.klient = index.klient;
                            index.klient = temp;
                        }
                        index = index.następny;
                    }
                    cur = cur.następny;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka mojaLista = new Kolejka();
            Klient a = new Klient("Sapko", 1, TypPłatności.BonTowarowy, 10);
            Klient b = new Klient("Nowak", 3, TypPłatności.BonTowarowy, 15);
            Klient c = new Klient("Kowalski", 2, TypPłatności.BonTowarowy, 5);
            Klient d = new Klient("Dupa", 5, TypPłatności.BonTowarowy, 50);
            Klient e = new Klient("Dupsko", 0, TypPłatności.Gotówka, 20);
            mojaLista.DodajDoGłowy(a);
            mojaLista.DodajDoGłowy(b);
            mojaLista.DodajDoGłowy(c);
            mojaLista.DodajDoGłowy(d);
            mojaLista.Wyświetl();
            Console.WriteLine(mojaLista.Wyszukaj("Dupa"));
            mojaLista.Zamień("Sapko", "Dupa");
            mojaLista.Wyświetl();
            mojaLista.Wstaw(e, 3);
            Console.WriteLine("----");
            mojaLista.Wyświetl();
            mojaLista.Sort();
            Console.WriteLine("+++++++");
            mojaLista.Wyświetl();
            //mojaLista.Zapisz("dupsko.txt");
        }
    }
}