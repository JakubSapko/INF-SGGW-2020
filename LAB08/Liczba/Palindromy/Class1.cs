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
            if ((znak>=97 && znak<=122) || (znak>=65 && znak<=90) || (Sprawdz(polskie, znak)) || znak == 32)
            {
                return true;
            }
            return false;
        }
        public static string UsunZnaki(string tekst)
        {
            char[] polskie = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś', 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' };
            string wyjscie = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (CzyLiterka(tekst[i]))
                {
                    wyjscie += Convert.ToChar(tekst[i]);
                }

            }

            return wyjscie;
        }
        public static string UsunPodwojneSpacje(string tekst)
        {
            string wyjscie = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    if (i != tekst.Length - 1 && tekst[i + 1] == ' ')
                    {

                    }
                    else
                    {
                        wyjscie += tekst[i];
                    }
                }
                else { wyjscie += tekst[i]; }
            }
            return wyjscie;
        }

        public static int IleWyrazow(string tekst)
        {
            int counter = 0;
            for (int i = 0; i<tekst.Length; i++)
            {
                if (tekst[i] ==' ')
                {
                    counter++;
                }
            }
            return counter + 1;
        }

        public static string[] ZwrocTabliceWyrazow(string tekst)
        {
            int ilość = IleWyrazow(tekst);
            string[] wyjscie = new string[ilość];
            for (int j = 0; j < ilość; j++) {
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] != ' ')
                    {
                        wyjscie[j] += tekst[i];
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return wyjscie;
        }

        public static string[] UsunDuplikaty(string[] tablica)
        {
            string tekst = "";
            int dlugosc = tablica.Length;
            for(int i = 0; i<dlugosc; i++) {
                int a = 0;
                if (i == 0)
                {
                    tekst += tablica[0] + " ";
                }
                else
                {
                    for (int w = i - 1; w >= 0; w--)
                    {
                        if(tablica[w] != tablica[i])
                        {
                            a++;
                        }
                    }
                    if (a == i)
                    {
                        tekst += tablica[i] + " ";
                    }
                }
            }
            return ZwrocTabliceWyrazow(tekst);
        }
    }
}
