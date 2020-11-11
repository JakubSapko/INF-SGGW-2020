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
            StreamReader sr_licznik = new StreamReader(path);
            StreamReader sr = new StreamReader(path);
            int wymiar = 0;
            while (!sr_licznik.EndOfStream)
            {
                sr_licznik.ReadLine();
                wymiar++;
            }
            /*
             * Liczby w macierzy zawsze z przedziału [10, 99]
             * Wers zapisywany jest w formacie 10 11 12 13 itd.
             * Macierz jest zawsze kwadratowa
             * To oznacza ze liczba znakow w wersie jest rowna:
             * Liczba znakow w wersie = 2 znaki * liczba liczb w wersie + ilosc spacji
             */
            int wymiar2 = (2 * wymiar) + (wymiar - 1);
            int[,] macierz = new int[wymiar, wymiar];
            Console.WriteLine(wymiar);
            for(int i = 0; i<wymiar; i++)
            {
                string wers = sr.ReadLine();
                int h = 0;
                for (int j = 0; j < wymiar2 ; j++)
                {
                    macierz[i, h++] = Int32.Parse(Convert.ToString(wers[j]) + wers[j + 1]);
                }   
            }
            return macierz;
        }
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
                    int result = (minEnd - subtr) / (step == 0 ? 1 : matrix[step - 1, step - 1]);  //divide by 1 if step == 0, else divide by matrix[step-1, step-1];
                    matrix[i, j] = result;
                }
            }
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\jakub\\Desktop\\output.txt";
            string path_test = "C:\\Users\\jakub\\Desktop\\dummymatrix.txt";
            int[,] matrix1 = Macierz(3);
            int[,] matrix2;
            WyswietlMacierz(matrix1);
            Zapisz(matrix1, path);
            Console.WriteLine(Determinant(matrix1));
            matrix2 = OdczytajTablicę(path_test);
            WyswietlMacierz(matrix2);
            Console.WriteLine(Determinant(matrix2));
        }
    }
}
