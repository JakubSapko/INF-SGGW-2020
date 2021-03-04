using System;

namespace Zadanie5
{
    class Calculator
    {
        double x;
        double y;
        double wynik;

        public Calculator()
        {
 
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }
        public double Dodaj()
        {
            return wynik = x + y;
        }
        public double Odejmij()
        {
            return wynik = x - y;
        }
        public double Pomnoz()
        {
            return wynik = x * y;
        }
        public double Podziel()
        {
            return wynik = x / y;
        }

        public void wypisz()
        {
            Console.WriteLine(wynik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.wypisz();
            calc.setX(6.0);
            calc.setY(2.0);
            Console.WriteLine(calc.Dodaj());
            Console.WriteLine(calc.Odejmij());
            Console.WriteLine(calc.Podziel());
            Console.WriteLine(calc.Pomnoz());
        }
    }
}
