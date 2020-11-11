using System;

namespace Palindromy
{
    public class Palindrom
    {
        public static bool Sprawdz(char[] ar, char litera)
        {
            for (int i = 0; i<ar.Length; i++)
            {
                if (ar[i] == litera)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CzyLiterka(char znak)
        {
            char[] polskie = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś', 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' };
            if ((znak>=97 && znak<=122) || (znak>=65 && znak<=90) || (Sprawdz(polskie, znak)))
            {
                return true;
            }
            return false;
        }
    }
}
