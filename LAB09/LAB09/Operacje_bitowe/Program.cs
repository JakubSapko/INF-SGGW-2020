﻿using System;

namespace Operacje_bitowe
{
    class Program
    {
        static string ZwrocBinarnieAryt(ulong liczba)
        {
            string wyjscie = "";
            while (liczba != 0)
            {
                ulong rem = liczba % 2;
                wyjscie = Convert.ToString(rem) + wyjscie;
                liczba /= 2;
            }

            return wyjscie;
        }

        static string ZwrocBinarnieBit(ulong liczba)
        {
            string wyjscie = "";
            while (liczba != 0)
            {
                ulong rem = liczba & 1;
                wyjscie = Convert.ToString(rem) + wyjscie;
                liczba = liczba >> 1;
            }

            return wyjscie;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ulong liczba = 5;
            Console.WriteLine(ZwrocBinarnieAryt(liczba));
            Console.WriteLine(ZwrocBinarnieBit(liczba));

        }
    }
}
