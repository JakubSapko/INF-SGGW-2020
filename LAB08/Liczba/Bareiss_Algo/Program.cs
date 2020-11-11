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
        /// <param name="matrix">Macierz dla której szukamy wyzniacznka. Matrix which determinant is calculated.</param>
        /// <param name="number_of_columns">Liczba kolumn macierzy. Number of columns in matrix</param>
        /// <param name="step">Numer kroku który wykonujemy. Step number</param>
        static void Compute(int[,] matrix, int number_of_columns, int step)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
