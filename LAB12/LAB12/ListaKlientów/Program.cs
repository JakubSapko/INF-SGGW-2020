using System;

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

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
