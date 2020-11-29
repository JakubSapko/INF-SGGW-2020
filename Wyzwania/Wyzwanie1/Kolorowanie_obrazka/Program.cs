using System;

namespace Kolorowanie_obrazka
{
    class Program
    {
        static byte[,] Color(byte[,] data, int x0, int y0)
        {
            if (data[x0, y0] != 0)
            {
                return data;
            }
            else
            {
                data[x0, y0] = 2;
                if (x0+1<data.GetLength(1) && data[x0+1, y0] == 0) { Color(data, x0 + 1, y0); }
                if (x0-1>=0 && data[x0-1, y0] == 0) { Color(data, x0-1, y0); }
                if (y0+1<data.GetLength(0) && data[x0, y0 + 1] == 0) { Color(data, x0, y0 + 1); }
                if (y0-1>=0 && data[x0, y0 - 1] == 0) { Color(data, x0, y0 - 1); }
            }
            return data;
        }
        static void Main(string[] args)
        {
            byte[,] data = {
                { 0, 1, 1, 1, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 0, 1, 0, 0, 1, 0 },
                { 0, 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };
            byte[,] data2 = {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                { 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0},
                { 0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                { 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0},
                { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0},
                { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                { 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
                { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0},
                { 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0},
                { 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} 
            };
            Console.WriteLine("SCENARIUSZ TESTOWY #1");
            for(int i = 0; i<6; i++)
            {
                for (int j = 0; j<6; j++)
                {
                    Console.Write(data[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            data = Color(data, 0, 5);
            Console.WriteLine("=============");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(data[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("SCENARIUSZ TESTOWY #2");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(data2[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            data2 = Color(data2, 0, 5);
            Console.WriteLine("=============");
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Console.Write(data2[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
