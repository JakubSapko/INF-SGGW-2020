using System;

namespace RunCode
{
    class Program
    {
        static string ZamienNaMale(string tekst)
        {
            string wyjscie = "";
            char[] polskie_male = new char[] { 'ą', 'ć', 'ę', 'ź', 'ł', 'ń', 'ó', 'ż', 'ś'};
            char[] polskie_wielkie = new char[] { 'Ą', 'Ć', 'Ę', 'Ź', 'Ł', 'Ń', 'Ó', 'Ż', 'Ś' };
            for (int i = 0; i<tekst.Length; i++)
            {
                if (tekst[i] >= 65 && tekst[i] <= 90 || Array.Exists(polskie_wielkie, element => element==tekst[i]))
                {
                    if (Array.Exists(polskie_wielkie, element => element == tekst[i]))
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

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}