using System;

namespace RunCode
{
    class Program
    {
        static string UsunZnaki(string tekst)
        {
            char[] polskie = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś', 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' }; 
            string wyjscie = "";
            for (int i=0; i<tekst.Length; i++)
            {
                if ((tekst[i]>=97 && tekst[i]<=122) || (tekst[i]>=65 && tekst[i]<= 90) || (Array.Exists(polskie, element => element == tekst[i])))
                {
                    wyjscie += Convert.ToChar(tekst[i]);
                }
            }
            return wyjscie;
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}