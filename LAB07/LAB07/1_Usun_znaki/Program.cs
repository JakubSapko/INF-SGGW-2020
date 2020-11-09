using System;
using Moja;

namespace RunCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "t\\ta;T-a";
            Console.WriteLine(Metody.UsunZnaki(tekst));
            Console.ReadKey();
        }
    }
}