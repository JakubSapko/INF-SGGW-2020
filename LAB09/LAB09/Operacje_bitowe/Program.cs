using System;

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

        static int IleJedynekItr(uint liczba)
        {
            int counter = 0;
            //string binarna = ZwrocBinarnieBit(liczba);
            for (int i = 0; i<32; i++)
            {
                if ((liczba & (1<<i)) != 0) { counter++; }
                liczba = liczba >> 1;
            }
            return counter;
        }

        static int IleJedynekRek(ulong liczba)
        {
            if (liczba == 0)
            {
                return 0;
            }
            if ((liczba & 1) == 1)
            {
                return 1 + IleJedynekRek(liczba >> 1);
            }
            else
            {
                return IleJedynekRek(liczba >> 1);
            }
        }

        static uint UstawBit(int stara_wartosc_rejestru, int ktory_bit, int wartosc)
        {
            int mask = 1 << ktory_bit;
            return (uint)((stara_wartosc_rejestru & ~mask) | ((wartosc << ktory_bit) & mask));
        }
        //do poprawy 
        static uint ZwrocLiczbeZBitow_7_11(uint rejestr)
        {
            rejestr >>= 7;
            return rejestr & 0x1F;
        }
        static uint TemperaturaWody(uint rejest)
        {
            uint bity = ZwrocLiczbeZBitow_7_11(rejest);
            return bity;
        }


        static void Main(string[] args)
        {
            ulong liczba = 5;
            uint liczba2 = 5;
            int mask = 1 << 2;
            //Console.WriteLine(mask);
            //Console.WriteLine(~mask);
            //liczba2 = UstawBit(liczba2, 1, 1);
            //Console.WriteLine(liczba2);
            //Console.WriteLine(ZwrocBinarnieAryt(liczba));
            //Console.WriteLine(ZwrocBinarnieBit(liczba));
            //Console.WriteLine(IleJedynekItr(liczba2));
            //Console.WriteLine(IleJedynekRek(liczba2));
            int dana = 1024;
            //Console.WriteLine(ZwrocBinarnieBit(dana));
            //Console.WriteLine(ZwrocBinarnieBit((ulong)dana));
            //Console.WriteLine(ZwrocNaBitach(dana));
            TemperaturaWody((uint)dana);
        }
    }
}
