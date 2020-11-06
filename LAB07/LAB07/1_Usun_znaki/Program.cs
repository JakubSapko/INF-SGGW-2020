using System;

namespace RunCode
{
    class Program
    {
        static bool Sprawdz(char[] ar, char litera)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == litera)
                {
                    return true;
                }
            }
            return false;
        }
        static string UsunZnaki(string tekst)
        {
            char[] polskie = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś', 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' }; 
            string wyjscie = "";
            for (int i=0; i<tekst.Length; i++)
            {
                if ((tekst[i]>=97 && tekst[i]<=122) || (tekst[i]>=65 && tekst[i]<= 90) || Sprawdz(polskie, tekst[i]))
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