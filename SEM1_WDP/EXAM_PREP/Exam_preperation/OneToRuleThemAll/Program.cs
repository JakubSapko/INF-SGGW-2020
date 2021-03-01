using System;

namespace OneToRuleThemAll
{
    class Program
    {
        public class Student
        {
            public string nazwisko;
            public int ocena;

            public Student(string nazwisko, int ocena)
            {
                this.nazwisko = nazwisko;
                this.ocena = ocena;
            }

            public static Student DodajStudenta()
            {
                Console.WriteLine("Podaj nazwisko");
                string nazwisko = Console.ReadLine();
                Console.WriteLine("Podaj ocene");
                int ocena = Convert.ToInt32(Console.ReadLine());
                return new Student(nazwisko, ocena);
            }

            public static Student Prymus(Student[] studenci)
            {
                int max = studenci[0].ocena;
                Student prymus = studenci[0];
                for(int i = 1; i<studenci.Length; i++)
                {
                    if (studenci[i].ocena > max)
                    {
                        max = studenci[i].ocena;
                        prymus = studenci[i];
                    }
                }
                return prymus;
            }

        }
        //--- Exercise 1 - Counting how many numbers starting with "7" are there in an array of numbers ---//
        static int Ile(int[] T)
        {
            int counter = 0;
            for (int i = 0; i<T.Length; i++)
            {
                int dana = Math.Abs(T[i]);
                while (dana >= 10)
                {
                    dana /= 10;
                }
                if (dana == 7)
                {
                    counter++;
                }
            }
            return counter;
        }
        //--- Exercise 2 - summing every number that isnt divisible by 3 and, at the same time, is divisible by 7 in a given range ---//
        static int Sumuj(int start, int koniec)
        {
            int bufor = start;
            int suma = 0;
            while (bufor <= koniec)
            {
                if (bufor % 3 != 0 && bufor % 7 == 0)
                {
                    suma += bufor;
                }
                bufor++;
            }
            return suma;
        }

        static int SumRek(int n)
        {
            if (n > 1)
            {
                if (n % 7 == 0) { return n + SumRek(n - 1); }
                else { return SumRek(n - 1); }
            }
            else
            {
                return 0;
            }
        }
        /*static string Zwroc(string tekst)
        {

        }*/
        static void Main(string[] args)
        {
            int[] T = { 1, 71, 17, 77, 700, 70000, 713411345, 1, 3, 0, 15 };
            // 1st exercise
            Console.WriteLine(Ile(T));
            // 2nd exercise
            Console.WriteLine(Sumuj(3, 21));
            // 3rd exercise
            Console.WriteLine(SumRek(7));

            Student[] studenci = new Student[5];
            for (int i = 0; i<5; i++)
            {
                studenci[i] = Student.DodajStudenta();
            }

            Student prymus = Student.Prymus(studenci);
            Console.WriteLine("Najwiekszy kozak o sredniej {0}, to: {1}", prymus.ocena, prymus.nazwisko);
        }
    }
}
