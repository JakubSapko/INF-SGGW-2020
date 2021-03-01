using System;

namespace P2_Przeszukiwanie_tablicy_dwuwymiarowej
{
    class Program
    {
        static bool CzyJest(int[,] tablica, int liczba)
        {
            for (int i = 0; i<tablica.GetLength(0); i++)
            {
                for (int j = 0; j<tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] == liczba) { return true; }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] ar = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            Console.WriteLine(CzyJest(ar, 1));
            Console.WriteLine(CzyJest(ar, 2));
            Console.WriteLine(CzyJest(ar, 3));
            Console.WriteLine(CzyJest(ar, 4));
            Console.WriteLine(CzyJest(ar, 5));
            Console.WriteLine(CzyJest(ar, 6));
            Console.WriteLine(CzyJest(ar, 7));
            Console.WriteLine(CzyJest(ar, 8));
            Console.WriteLine(CzyJest(ar, 0));
        }
    }
}
