using System;

namespace Bareiss_Algo
{
    /// <summary>
    /// PL: Implementacja algorytmu Bareiss'a.
    /// ENG: Bareiss Algorithm implementation.
    /// https://en.wikipedia.org/wiki/Bareiss_algorithm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Oblicza wyznacznik zadanej macierzy.
        /// Computes determinant of the given matrix.
        /// </summary>
        /// <param name="matrix"> 
        /// Macierz dla której szukamy wyznacznika.
        /// Matrix which determinant is calculated.
        /// </param>
        static int Determinant(int[,] matrix)
        {
            int number_of_columns = matrix.GetLength(1) - 1;
            for (int step = 0; step<number_of_columns; step++)
            {
                Compute(matrix, number_of_columns, step);
            }

            return matrix[matrix.GetLength(0) - 1, number_of_columns];

        }
        /// <summary>
        /// Oblicza jeden krok algorytmu Bareissa
        /// Computes one step of the Bareiss Algorithm
        /// </summary>
        /// <param name="matrix">Macierz dla której szukamy wyznacznika. Matrix which determinant is calculated.</param>
        /// <param name="number_of_columns">Liczba kolumn macierzy. Number of columns in matrix</param>
        /// <param name="step">Numer kroku który wykonujemy. Step number</param>
        static void Compute(int[,] matrix, int number_of_columns, int step)
        {
            for (int i = step + 1; i <= number_of_columns; i++)
            {
                for (int j = step + 1; j <= number_of_columns; j++)
                {
                    int minEnd = matrix[step, step] * matrix[i, j];
                    int subtr = matrix[i, step] * matrix[step, j];
                    int result = (minEnd - subtr) / (step == 0 ? 1 : matrix[step - 1, step - 1]);//divide by 1 if step == 0, else divide by matrix[step-1, step-1];
                    matrix[i, j] = result;
                }
            }
        }

        static void Main(string[] args)
        {
            //Dummy data
            int[,] matrix = new int[,]
            {
                {1, 2, 3, 4, 5 },
                {0, 2, 6, 7, 10 },
                {1, 2, 0, 0, 3 },
                {1, 1, 3, 2, 2 },
                {3, 2, 3, 5, 6}
            };
            Console.WriteLine($"Wyznacznik macierz: {Determinant(matrix)}");
        }
    }
}
