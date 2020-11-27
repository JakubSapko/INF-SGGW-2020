using System;
using System.IO;

namespace Lista_jednokierunkowa
{
    class Lista
    {

        public class Węzeł
        {
            // w węźle przechowujemy "imię"
            public string imię;
            public Węzeł następny;
        }

        public Węzeł głowa;

        public bool CzyPusta()
        {
            return głowa == null;
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
        public void DodajDoGłowy(string imię)
        {
            Węzeł tmp = new Węzeł();
            tmp.imię = imię;
            // dodany element staje się głową, więc dotychczasowa głowa staje się obiektem, który jest "następny"
            tmp.następny = głowa;
            // dodany element staje się głową
            głowa = tmp;
        }

        public string UsuńZGłowy()
        {
            string tmp;
            if (głowa != null) // sprawdzamy, czy lista nie jest pusta
            {
                tmp = głowa.imię;
                głowa = głowa.następny;
                return tmp;
            }
            else
                throw new Exception("Lista pusta!");
        }

        void ZapiszWęzeł(StreamWriter sw, Węzeł w)
        {
            sw.WriteLine(w.imię);
        }

        Węzeł OdczytajWęzeł(StreamReader sr)
        {
            if (sr.EndOfStream) { return null; }
            else
            {
                Węzeł odczyt = new Węzeł();
                odczyt.imię = sr.ReadLine();
                return odczyt;
            }
        }

        public void ZapiszListę(string nazwaPliku)
        {
            StreamWriter sw = new StreamWriter(nazwaPliku);
            Węzeł x;
            x = głowa;
            while (x != null)
            {
                ZapiszWęzeł(sw, x);
                x = x.następny;
            }
            sw.Close();
        }

        public void OdczytajListę(string nazwaPliku)
        {
            StreamReader sr = new StreamReader(nazwaPliku);
            while (!sr.EndOfStream)
            {
                DodajDoGłowy(OdczytajWęzeł(sr).imię);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista mojaLista = new Lista();

            mojaLista.DodajDoGłowy("Ola");
            mojaLista.DodajDoGłowy("Ada");
            mojaLista.DodajDoGłowy("Ula");
            mojaLista.DodajDoGłowy("Ala");
            mojaLista.ZapiszListę("lista.txt");
            Console.WriteLine("Liczba elementów na liście " + mojaLista.ZwróćRozmiar());

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Usuwam: " + mojaLista.UsuńZGłowy());
            }
            Console.WriteLine("Liczba elementów na liście " + mojaLista.ZwróćRozmiar());
            mojaLista.OdczytajListę("lista.txt");
            Console.WriteLine("Liczba elementów na liście " + mojaLista.ZwróćRozmiar());
            Console.ReadKey();
        }
    }
}
