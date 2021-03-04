using System;

namespace Zadanie2
{
    class Student
    {
        string imie;
        string nazwisko;
        int nr;
        int sem;
        public Student(string imie, string nazwisko, int nr, int sem)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nr = nr;
            this.sem = sem;
        }
        public void ZmienImie(string newImie)
        {
            imie = newImie;
        }
        public void ZmienNazwisko(string newNazwisko)
        {
            nazwisko = newNazwisko;
        }
        public void ZmienNr(int newNr)
        {
            nr = newNr;
        }
        public void ZmienSem(int newSem)
        {
            sem = newSem;
        }
        public void WyswietlStudenta()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("*Imie: " + imie);
            Console.WriteLine("*Nazwisko: " + nazwisko);
            Console.WriteLine("*Nr: " + nr);
            Console.WriteLine("*Sem: " + sem);
        }
    }
    class Program
    {
 
        static void Main(string[] args)
        {
            Student stud = new Student("Jakub", "Sapko", 208499, 2);
            stud.WyswietlStudenta();
            stud.ZmienImie("Adam");
            stud.WyswietlStudenta();
        }
    }
}
