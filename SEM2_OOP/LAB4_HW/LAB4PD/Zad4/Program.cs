using System;

namespace Zad4
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        abstract public void Wyswietl();
            
    }
    class Uczen : Osoba
    {
        int rocznik;
        public Uczen(string imie, string nazwisko, int rocznik) : base(imie, nazwisko)
        {
            this.rocznik = rocznik;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Imie: {0}, Nazwisko: {1}, rocznik: {2}", imie, nazwisko, rocznik);
        }
    }
    class Student : Osoba
    {
        string kierunek;
        public Student(string imie, string nazwisko, string kierunek) : base(imie, nazwisko)
        {
            this.kierunek = kierunek;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Imie: {0}, Nazwisko: {1}, kierunek: {2}", imie, nazwisko, kierunek);
        }
    }
    class Emeryt : Osoba
    {
        double emerytura;
        public Emeryt(string imie, string nazwisko, double emerytura) : base(imie, nazwisko)
        {
            this.emerytura = emerytura;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Imie: {0}, Nazwisko: {1}, wysokosc emerytury: {2}", imie, nazwisko, emerytura);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uczen u = new Uczen("Jan", "Kowalski", 1999);
            Student stud = new Student("Bożydar", "Wiśniowiecki", "fizyka");
            Emeryt em = new Emeryt("Bogdan", "Nowak", 2000);
            Osoba[] osoby = { u, stud, em };
            foreach(var osoba in osoby)
            {
                osoba.Wyswietl();
            }
        }
    }
}
