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
        public override string ToString()
        {
            return (""+ imie + " " + nazwisko + ", urodzony w " + rok_urodzenia + " roku, plec: " + plec); 
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
        public override string ToString()
        {
            return ("Student: " + base.ToString() + " numer indeksu: " + numer_indeksu);
        }
    }
    class Wykladowca : Osoba
    {
        string tytul;
        public Wykladowca(string imie, string nazwisko, int rok_urodzenia, string plec, string tytul) : base(imie, nazwisko, rok_urodzenia, plec)
        {
            this.tytul = tytul;
        }
        public string Tytul
        {
            get => tytul;
            set
            {
                tytul = value;
            }
        }
        public override string ToString()
        {
            return ("Wykladowca: " + base.ToString() + " tytul: " + tytul);
        }
    }
    class Stypendysta : Student
    {
        int stypendium;
        public Stypendysta(string imie, string nazwisko, int rok_urodzenia, string plec, int nr_indeksu, int stypendium) : base(imie, nazwisko, rok_urodzenia, plec, nr_indeksu)
        {
            this.stypendium = stypendium;
        }
        public int Stypendium
        {
            get => stypendium;
            set
            {
                if (value > 0)
                {
                    stypendium = value;
                }
            }
        }
        public override string ToString()
        {
            return ("Stypendysta: " + base.ToString() + " wysokosc stypendium: " + stypendium);
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
            Console.WriteLine(Ja);
            //Student
            Student Ja2 = new Student("Jakub", "Sapko", 1999, "m", 208499);
            Console.WriteLine(Ja2);
            //Wykladowca
            Wykladowca wyk = new Wykladowca("Jan", "Kowalski", 1970, "m", "drhab");
            Console.WriteLine(wyk);
            //Stypendysta
            Stypendysta styp = new Stypendysta("Jakub", "Sapko", 1999, "m", 208499, 20);
            Console.WriteLine(styp);
        }
    }
}
