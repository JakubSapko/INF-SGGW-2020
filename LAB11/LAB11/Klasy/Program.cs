using System;
using System.IO;
using System.Text;

namespace Klasy
{
    class Student
    {
        public string imię;
        public string nazwisko;
        public int rokUrodzenia;
        double ocena;
        // konstruktor struktury
        // należy zainicjalizować wszystkie pola struktury
        public Student(string I, string nazwisko, int rokUrodzenia, double ocena)
        {
            imię = I;
            this.nazwisko = nazwisko; // this - odwołanie do pola struktury
            this.rokUrodzenia = rokUrodzenia;
            this.ocena = ocena;
        }
        public double GetOcena()
        {
            return ocena;
        }
        public string ZwróćInformacje()
        {
            return imię + " " + nazwisko + " " + rokUrodzenia + " " + ocena;
        }
        public void Edytuj(string imie, string nazwisko, int rokUrodzenia, double ocena)
        {
            this.imię = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.ocena = ocena;
        }
    }
    class Uczelnia
    {
        // na uczelni będzie wiele wydziałów
        Wydział[] wydzialy;
        int licznikWydziałów;
    }

    class Wydział
    {
        // na wydziale będzie wiele list studentów
        ListaStudentów[] roczniki;
        int licznikRoczników;
    }
    class ListaStudentów
    {
        // tablica studentów
        public Student[] lista;
        // liczy, ile studentów jest na liście
        public int licznik;

        // konstruktor - inicjalizuje wszystkie pola
        public ListaStudentów(Student[] lista)
        {
            this.lista = lista;
            licznik = 0;
        }

        public ListaStudentów(int rozmiar)
        {
            this.lista = new Student[rozmiar];
            licznik = 0;
        }
        // dodaje studenta do listy
        public void DodajDoListy(Student o)
        {
            // jeśli w tablicy jest jeszcze miejsce, dodajemy studenta
            if (licznik < lista.Length)
            {
                lista[licznik] = o;
                licznik++;
            }
            else
            {
                // jeśli tablica jest wypełniona, zwiększamy jej rozmiar
                Array.Resize(ref lista, lista.Length + 4);
                // i dodajemy studenta
                lista[licznik] = o;
                licznik++;
            }
        }
        public void UsuńZListy(int doUsuniecia)
        {
            if (doUsuniecia < licznik && doUsuniecia >= 0)
            {
                // usunięcie polega na przesunięciu wszystkich elementów "za" usuwanym elementem o jedną pozycję wyżej
                for (int i = doUsuniecia; i < this.licznik - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                licznik--;
            }
        }
        public string ZwróćInformacje()
        {
            string text = "";
            // zwraca wszystkie elementy tablicy
            for (int i = 0; i < licznik; i++)
            {
                text += "" + (i + 1) + " " + lista[i].ZwróćInformacje() + "\n";
            }
            return text;
        }
    }


    class Program
    {
        static string ZwrocStudenta(Student s)
        {
            return s.imię + ";" + s.nazwisko + ";" + s.rokUrodzenia + ";" + s.GetOcena();
        }
        static void ZapiszStudenta(Student s, StreamWriter sw)
        {
            sw.Write(ZwrocStudenta(s));
            sw.Write("\n");
        }
        static void ZapiszListęStudentów(ListaStudentów ls, string nazwapliku)
        {
            StreamWriter sw = new StreamWriter(nazwapliku, true, Encoding.UTF8);
            for (int i = 0; i < ls.licznik; i++)
            {
                ZapiszStudenta(ls.lista[i], sw);
            }
            sw.Close();
        }
        static Student OdczytajStudenta(StreamReader sr)
        {
            string studentInfo = sr.ReadLine();
            string imie = "", nazwisko = "", rok = "", ocena = "";
            Console.WriteLine(studentInfo);
            int i = 0;
            while (studentInfo[i] != ';')
            {
                imie += studentInfo[i];
                i++;
            }
            i++;
            while (studentInfo[i] != ';')
            {
                nazwisko += studentInfo[i];
                i++;
            }
            i++;
            while (i<studentInfo.Length && studentInfo[i] != ';')
            {
                rok += studentInfo[i];
                i++;
            }
            i++;
            while (i<studentInfo.Length && studentInfo[i] != ';')
            {
                ocena += studentInfo[i];
                i++;
            }
            Student student = new Student(imie, nazwisko, Convert.ToInt16(rok), Convert.ToDouble(ocena));
            return student;
        }
        static ListaStudentów OdczytajListę(string nazwapliku)
        {
            StreamReader sr = new StreamReader(nazwapliku);
            int counter = 10;
            ListaStudentów ls = new ListaStudentów(counter);
            while (!sr.EndOfStream)
            {
                Student s = OdczytajStudenta(sr);
                ls.DodajDoListy(s);
            }
            sr.Close();
            return ls;
        }

        static double ObliczSrednia(ListaStudentów ls)
        {
            double srednia = 0;
            double all = 0;
            int counter = 0;
            for (int i = 0; i<ls.licznik; i++)
            {
                all += ls.lista[i].GetOcena();
                counter++;
            }
            srednia = all / counter;
            return srednia;
        }

        static string ZmienPrzecinek(string wejscie)
        {
            string wyjscie = "";
            for (int i = 0; i<wejscie.Length; i++)
            {
                if(wejscie[i] == ',')
                {
                    wyjscie += ".";
                }
                else
                {
                    wyjscie += wejscie[i];
                }
            }
            return wyjscie;
        }

        static void Konwertuj(string wejscie, string wyjscie)
        {
            StreamWriter sw = new StreamWriter(wyjscie, true, Encoding.UTF8);
            ListaStudentów ls = OdczytajListę(wejscie);
            double srednia = ObliczSrednia(ls);
            int aktualny_rok = DateTime.Now.Year;
            for(int i = 0; i<ls.licznik; i++)
            {
                Student s = ls.lista[i];
                double srednia_studenta = s.GetOcena();
                string linia = ZwrocStudenta(s);
                //wiek studenta
                linia += ";" + (aktualny_rok - s.rokUrodzenia);
                //zamiana przecinka na kropke i roznica miedzy srednia a srednia grupy
                linia += ";" + ZmienPrzecinek(Convert.ToString(srednia - srednia_studenta));
                sw.WriteLine(linia);
            }
            sw.Close();
        }


        static void Main(string[] args)
        {
            //wartosci probne z moodla
            Student Janek = new Student("Janek", "Nowak", 1996, 4.64);
            Student Jadzia = new Student("Jadzia", "Nowicka", 1992, 3.87);
            Student Wojtek = new Student("Wojtek", "Kowalski", 1996, 4.04);
            Student Malgosia = new Student("Małgosia", "Kowalewska", 1994, 4.98);

            // wyświetlenie struktury
            Console.WriteLine("Wyświetlenie informacji o Jadzi");
            Console.WriteLine(ZwrocStudenta(Jadzia));

            // inicjalizujemy strukturę ListaOsób tablicą studentów o rozmiarze 10

            ListaStudentów lista = new ListaStudentów(10);
            Console.WriteLine("Dodaję 4 elementy do listy i wyświetlam ją");
            lista.DodajDoListy(Janek);
            lista.DodajDoListy(Jadzia);
            lista.DodajDoListy(Wojtek);
            lista.DodajDoListy(Malgosia);
            Console.WriteLine(lista.ZwróćInformacje());


            ZapiszListęStudentów(lista, "lista.csv");
            Console.WriteLine("Zapisano listę");

            ListaStudentów odczytana = OdczytajListę("lista.csv");
            Console.WriteLine("Odczytana lista");
            Console.WriteLine(odczytana.ZwróćInformacje());

            Console.WriteLine("Konwersja plików");
            Konwertuj("lista.csv", "nowalista.csv");
            Console.WriteLine("Wciśnij klawisz");


            Console.ReadKey();
        }
    }
}
