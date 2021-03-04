using System;

namespace Zadanie3
{
    class Konto
    {
        string nr;
        int saldo;
        public int ZwrocSaldo()
        {
            return saldo;
        }
        public Konto(string nr)
        {
            this.nr = nr;
        }

        public int Wplac(uint w)
        {
            return saldo += (int)w;
        }
        public int Wyplac(uint w)
        {
            if (saldo >= w)
            {
                return saldo -= (int)w;
            }
            else
            {
                return saldo;
            }
        }
    }
    class Klient
    {
        string imie;
        string nazwisko;
        Konto konto;       
        public Klient(string imie, string nazwisko, string nr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            konto = new Konto(nr);
        }
        public void Wyswietl()
        {
            Console.WriteLine(imie + " " + nazwisko);
        }

        public int PodajMajatek()
        {
            return konto.ZwrocSaldo();
        }
        public int Wplac(uint kwota)
        {
            return konto.Wplac(kwota);
        }
        public int Wyplac(uint kwota)
        {
            return konto.Wyplac(kwota);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Klient k = new Klient("Adam", "Kowalski", "2131412");
            k.Wplac(10000);
            k.Wyplac(1000000);
            k.Wyplac(100);
            k.Wyswietl();
            Console.WriteLine(k.PodajMajatek());
        }
    }
}
