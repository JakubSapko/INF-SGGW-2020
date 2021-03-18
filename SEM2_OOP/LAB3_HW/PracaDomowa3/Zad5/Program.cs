using System;

namespace Zad5
{
    class Osoba
    {
        string imie;
        string nazwisko;
        int rok_urodzenia;
        string plec;
        public Osoba(string imie, string nazwisko, int rok_urodzenia, string plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rok_urodzenia = rok_urodzenia;
            this.plec = plec;
        }
        public string Imie
        {
            get => imie;
            set
            {
                imie = value;
            }
        }
        public string Nazwisko
        {
            get => Nazwisko;
            set
            {
                Nazwisko = value;
            }
        }
        public int Rok
        {
            get => rok_urodzenia;
            set
            {
                if ((value>=1900) && (value <= 2021))
                {
                    rok_urodzenia = value;
                }
            }
        }
        public string Plec
        {
            get => plec;
            set { plec = value; }
        }
        public void Odczytaj()
        {
            Console.WriteLine("Osoba: {0}, {1}, {2}, {3}", imie, nazwisko, rok_urodzenia, plec);
        }
    }
    class Student : Osoba
    {
        int numer_indeksu;
        public Student(string imie, string nazwisko, int rok_urodzenia, string plec, int numer_indeksu) : base(imie, nazwisko, rok_urodzenia, plec)
        {
            this.numer_indeksu = numer_indeksu;
        }
        public int Numer
        {
            get => numer_indeksu;
            set
            {
                if ((value>0) && (value <= 999999))
                {
                    numer_indeksu = value;
                }
            }
        }
        public void Odczytaj()
        {
            base.Odczytaj();
            Console.WriteLine(numer_indeksu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba
            Osoba Ja = new Osoba("Jakub", "Sapko", 1999, "m");
            Console.WriteLine(Ja.Imie);
            Ja.Imie = "Andrzej";
            Console.WriteLine(Ja.Imie);
            Ja.Plec = "f";
            Console.WriteLine(Ja.Plec);
            Ja.Odczytaj();
            Student Ja2 = new Student("Jakub", "Sapko", 1999, "m", 208499);
            Ja2.Odczytaj();
        }
    }
}
