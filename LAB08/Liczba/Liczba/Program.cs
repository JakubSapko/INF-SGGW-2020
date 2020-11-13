using System;
using System.IO;

namespace Liczba
{
    class Program
    {
        static void Zapisz(int liczba, string path)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(path);
                sw.WriteLine(liczba);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        static int OdczytajLiczbę(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                int liczba = Convert.ToInt32(sr.ReadLine());
                return liczba;
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
            Zapisz(10, @"C:\Users\jakub\Desktop\test.txt");
            Console.WriteLine(OdczytajLiczbę(@"C:\users\jakub\Desktop\test.txt"));
            Zapisz(42, @"C:\Users\jakub\Desktop\test.txt");
            Console.WriteLine(OdczytajLiczbę(@"C:\Users\jakub\Desktop\test.txt"));
        }
    }
}
