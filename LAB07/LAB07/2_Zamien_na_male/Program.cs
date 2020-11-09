using System;
using Moja;

namespace RunCode
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string tekst = "Mama, Ala i Ola.";
            Console.WriteLine(Metody.ZamienNaMale(tekst));
            Console.ReadKey();
        }
    }
}