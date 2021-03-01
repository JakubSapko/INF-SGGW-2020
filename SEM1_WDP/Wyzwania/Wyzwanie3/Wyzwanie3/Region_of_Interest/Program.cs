using System;
using System.Drawing;
using System.IO;


namespace Region_of_Interest
{
    class Program
    {
        static bool IsRed(int x, int y, Bitmap b)
        {
            Color red = Color.FromArgb(237, 28, 36);
            if (b.GetPixel(x, y) == red) { return true; }
            else { return false; }
        }
        static void ReturnUtmostPoints(Bitmap b)
        {
            StreamWriter sw = new StreamWriter("wynik.txt");
            StreamReader sr = new StreamReader("wynik.txt");
            Size size = b.Size;
            int width = b.Width;
            int height = b.Height;
            int xmin = 0,
                xmax = 0,
                ymin = 0,
                ymax = 0;
            int counter = 1;
            Console.WriteLine(size);
            for(int i = 0; i<width; i++)
            {
                for(int j = 0; j<height; j++)
                {
                    if(IsRed(i, j, b))
                    {
                        xmin = i;
                        ymin = j;
                        int k = 0;
                        int w = 0;
                        //tu sprawdzic czy IsRed(i, j, b) nie jest w jakims znanym prostokacie
                        //jezeli nie to:
                        while(IsRed(xmin+k, ymin, b))
                        {
                            xmax = xmin + k;
                            k++;
                            //Console.WriteLine("{0} {1} {2} {3} {4}", counter, xmin, xmax, ymin, ymax);
                        }
                        while(IsRed(xmax, ymin+w, b))
                        {
                            ymax = ymin + w;
                            w++;
                        }
                        Console.WriteLine("{0} {1} {2} {3} {4}", counter, xmin, xmax, ymin, ymax);
                        sw.WriteLine("{0} {1} {2} {3} {4}", counter, xmin, xmax, ymin, ymax);
                        break;
                    }
                }
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Bitmap obrazek = new Bitmap("zabawa.png");
            ReturnUtmostPoints(obrazek);
        }
    }
}
