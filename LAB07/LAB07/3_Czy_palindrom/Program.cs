using System;

namespace _3_Czy_palindrom
{
    class Program
    {
        public bool CzyPalindrom(string Word)
        {
            int i = 0, j = Word.Length - 1;
            for (; i < Word.Length - 1 && j >= 0 && Word[i] == Word[j]; i++, j--) ;
            return j == 0 ? true : false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
