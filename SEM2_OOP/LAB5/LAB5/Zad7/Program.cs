using System;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            string s = "ala ma kota";
            int n = 100000;
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                s += "ala ma kota";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();
            StringBuilder sb = new StringBuilder("ala ma kota", 10000);
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append(s);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
