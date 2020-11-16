using System;
using System.IO;

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

        public static void ZnajdzPalindromy(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] palindromy = { };
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string linia = UsunPodwojneSpacje(UsunZnaki(line));
                int wymiar = IleWyrazow(linia);
                string[] slowa = ZwrocTabliceWyrazow(linia);
                for (int i = 0; i<slowa.Length; i++)
                {
                    if (CzyPalindrom(slowa[i]))
                    {
                        palindromy
                    }
                }
            }
        }

    }
}
