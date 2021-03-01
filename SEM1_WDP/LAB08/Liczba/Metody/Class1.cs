using System;

namespace Metody
{
    public class Metody
    {
        public static bool Sprawdz(char[] ar, char litera)
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
        public static string UsunZnaki(string tekst)
        {
            char[] polskie = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś', 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' };
            string wyjscie = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] >= 97 && tekst[i] <= 122) || (tekst[i] >= 65 && tekst[i] <= 90) || Sprawdz(polskie, tekst[i]))
                {
                    wyjscie += Convert.ToChar(tekst[i]);
                }
            }
            return wyjscie;
        }
        public static string ZamienNaMale(string tekst)
        {
            string wyjscie = "";
            char[] polskie_male = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś' };
            char[] polskie_wielkie = new char[] { 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' };
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] >= 65 && tekst[i] <= 90 || Sprawdz(polskie_wielkie, tekst[i]))
                {
                    if (Sprawdz(polskie_wielkie, tekst[i]))
                    {
                        for (int j = 0; j < polskie_wielkie.Length; j++)
                        {
                            if (tekst[i] == polskie_wielkie[j])
                            {
                                wyjscie += polskie_male[j];
                            }

                        }
                    }
                    else
                    {
                        wyjscie += Convert.ToChar(Convert.ToInt32(tekst[i]) + 32);
                    }
                }
                else
                {
                    wyjscie += tekst[i];
                }
            }
            return wyjscie;
        }
        public static string OdwrocString(string tekst)
        {
            int dlg = tekst.Length;
            string reversed = "";
            for (int i = 1; i <= dlg; i++)
            {
                reversed += tekst[dlg - i];
            }
            return reversed;
        }
        public static bool CzyPalindrom(string Word)
        {
            string newWord = ZamienNaMale(UsunZnaki(Word));
            string reversed = OdwrocString(newWord);
            if (newWord == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
