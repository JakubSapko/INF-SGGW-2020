﻿using System;
using System.IO;
using System.Text;

namespace Klasy
{
    class Student
    {
        public string imię;
        public string nazwisko;
        public int rokUrodzenia;
        // konstruktor struktury
        // należy zainicjalizować wszystkie pola struktury
        public Student(string I, string nazwisko, int rokUrodzenia)
        {
            imię = I;
            this.nazwisko = nazwisko; // this - odwołanie do pola struktury
            this.rokUrodzenia = rokUrodzenia;
        }
        public string ZwróćInformacje()
        {
            return imię + " " + nazwisko + " " + rokUrodzenia;
        }
        public void Edytuj(string imie, string nazwisko, int rokUrodzenia)
        {
            this.imię = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
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
            return s.imię + ";" + s.nazwisko + ";" + s.rokUrodzenia;
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
            string imie = "", nazwisko = "", rok = "";
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
            while (studentInfo[i] != ';')
            {
                rok += studentInfo[i];
                i++;
            }
            i++;
            Student student = new Student(imie, nazwisko, Convert.ToInt16(rok));
            return student;
        }
        static ListaStudentów OdczytajListę(string nazwapliku)
        {
            StreamReader sr = new StreamReader(nazwapliku);
            int counter = 0;
            while (!sr.EndOfStream)
            {
                counter++;
            }
            ListaStudentów ls = new ListaStudentów(counter);
            while (!sr.EndOfStream)
            {
                Student s = OdczytajStudenta(sr);
                ls.DodajDoListy(s);
            }
            sr.Close();
            return ls;
        }
        static void Main(string[] args)
        {
            Student student = new Student("Jakub", "Sapko", 1999);
            Console.WriteLine(student.ZwróćInformacje());
            Console.WriteLine(ZwrocStudenta(student));
        }
    }
}
