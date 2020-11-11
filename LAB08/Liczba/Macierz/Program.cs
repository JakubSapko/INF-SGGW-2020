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
        /*static int[,] OdczytajTablicę(string path)
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
        }*/
        static int Determinant(int[,] matrix)
        {
            int number_of_columns = matrix.GetLength(1) - 1;
            for (int step = 0; step < number_of_columns; step++)
            {
                Compute(matrix, number_of_columns, step);
            }

            return matrix[matrix.GetLength(0) - 1, number_of_columns];

        }

        static void Compute(int[,] matrix, int number_of_columns, int step)
        {
            for (int i = step + 1; i <= number_of_columns; i++)
            {
                for (int j = step + 1; j <= number_of_columns; j++)
                {
                    int minEnd = matrix[step, step] * matrix[i, j];
                    int subtr = matrix[i, step] * matrix[step, j];
                    int result = (minEnd - subtr) / (step == 0 ? 1 : matrix[step - 1, step - 1]); 
                    matrix[i, j] = result;
                }
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\jakub\\Desktop\\deeznuts.txt";
            WyswietlMacierz(Macierz(3));
            Zapisz(Macierz(3), path);
            //WyswietlMacierz(OdczytajTablicę(path));
        }
    }
}
