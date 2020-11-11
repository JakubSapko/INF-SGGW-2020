using System;
using System.IO;

namespace Macierz
{
    class Program
    {
        static int[,] Macierz(int rozmiar)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rozmiar, rozmiar];
            for (int i = 0; i<rozmiar; i++)
            {
                for (int j = 0; j<rozmiar; j++)
                {
                    int numer = rnd.Next(10, 100);
                    matrix[i, j] = numer;
                }
            }
            return matrix;
        }

        static void WyswietlMacierz(int[,] macierz)
        {
            int rozmiar = macierz.GetLength(0);
            for (int i = 0; i<rozmiar; i++)
            {
                for (int j = 0; j<rozmiar; j++)
                {
                    Console.Write(macierz[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            
        }

        static void Zapisz(int[,] tab, string path)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path);
                for (int i = 0; i<tab.GetLength(0); i++)
                {
                    for (int j = 0; j<tab.GetLength(0); j++)
                    {
                        sw.Write(tab[i, j] + " ");
                    }
                    sw.Write("\n");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sw.Close();
            }
        }
        static int[,] OdczytajTablicę(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                int rozmiar = Convert.ToInt32(sr.ReadLine());
                int[,] matrix = new int[rozmiar, rozmiar];
                for (int i = 0; i < rozmiar; i++)
                {
                    for (int j = 0; j < rozmiar; j++)
                    {
                        int liczba = sr.Read();
                        matrix[i, j] = liczba;
                    }
                }
                return matrix;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\jakub\\Desktop\\deeznuts.txt";
            WyswietlMacierz(Macierz(3));
            Zapisz(Macierz(3), path);
            WyswietlMacierz(OdczytajTablicę(path));
        }
    }
}
