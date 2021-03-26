using System;

namespace Zad3
{
    abstract class Pracownik
    {
        protected string PESEL;
        protected string nazwisko;

        public Pracownik(string PESEL, string nazwisko)
        {
            this.PESEL = PESEL;
            this.nazwisko = nazwisko;
        }
        public abstract float ObliczPlace(float liczbaGodzin);
        public abstract string Info();
    }
    class PracownikFizyczny : Pracownik
    {
        float stawka;
        public PracownikFizyczny(string PESEL, string nazwisko, float stawka) : base(PESEL, nazwisko)
        {
            this.stawka = stawka;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return stawka * liczbaGodzin;
        }
        public override string Info()
        {
            return "Pracownik fizyczny: " + PESEL + " " + nazwisko;
        }
    }
    class PracownikBiurowy : Pracownik
    {
        protected float stawka, premia;
        public PracownikBiurowy(string PESEL, string nazwisko, float stawka, float premia) : base(PESEL, nazwisko)
        {
            this.stawka = stawka;
            this.premia = premia;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return stawka + premia * liczbaGodzin;
        }
        public override string Info()
        {
            return "Pracownik biurowy: " + PESEL + " " + nazwisko;
        }
    }
    class Kierownik : PracownikBiurowy
    {
        int ile_pracownikow;
        public Kierownik(string PESEL, string nazwisko, float stawka, float premia, int ile_pracownikow) : base(PESEL, nazwisko, stawka, premia)
        {
            this.ile_pracownikow = ile_pracownikow;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return (stawka + premia) * ile_pracownikow * liczbaGodzin;
        }
        public override string Info()
        {
            return "Kierownik: " + PESEL + " " + nazwisko;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PracownikBiurowy pb = new PracownikBiurowy("2312312321", "Kowalski", 30, 20);
            PracownikFizyczny pf = new PracownikFizyczny("2312312", "Nowak", 20);
            Kierownik kier = new Kierownik("6346346534", "Kulczyk", 200, 5000, 100);
            Pracownik[] pracownicy = { pf, pb, kier };
            int[] godziny = { 140, 120, 200 };
            ListaPlac(pracownicy, godziny);
            Console.WriteLine(typeof(Pracownik));
        }
        static void ListaPlac(Pracownik[] pracownicy, int[] godziny) 
        {
            float suma = 0;
            int index = 0;
            foreach(Pracownik pracownik in pracownicy)
            {
                float p = pracownik.ObliczPlace(godziny[index]);
                Console.WriteLine(pracownik.Info() + " " + p);
                suma += p;
                index++;
            }
            Console.WriteLine("Razem: " + suma);
        }
    }
}
