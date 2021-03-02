using System;

namespace Zadanie3
{
    class Program
    {
        public class Konto
        {
            public int nr;
        }
        public class Klient : Konto
        {
            public string imie;
            public string nazwisko;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
