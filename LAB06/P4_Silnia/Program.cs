using System;

namespace P4_Silnia
{
    class Program
    {
        static void Silnia()
        {
            for (int i = 1; i<11; i++)
            {
                int silnia = i;
                for (int j = 1; j<i; j++)
                {
                    silnia *= j;
                }
                Console.WriteLine(silnia);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Silnia();
        }
    }
}
