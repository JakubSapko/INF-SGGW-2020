using System;

namespace P1_char_napis
{
    class Program
    {
        static bool CzyWystepuje(string napis, char znak, int n = 0)
        {
            bool wynik = false;
            if (n == napis.Length)
                return false;
            if (napis[n] == znak)
                wynik = true;
            return wynik || CzyWystepuje(napis, znak, ++n);
        
        }
        static void Main(string[] args)
        {
            /*string napis = "pies";
            char znak = 'c';
            char znak2 = 'e';*/
            Console.WriteLine("Podaj string:");
            string x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj znak:");
            char z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(CzyWystepuje(x, z));
        }
    }
}
