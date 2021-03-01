using System;

namespace ROBOT
{
    class Program
    {
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
            ulong num = 63;
            Console.WriteLine(CieploZimnoBib.CieploZimno.Poszukiwanie(0));
            Console.WriteLine(ZwrocBinarnieBit(num));
            Console.WriteLine(ZwrocBinarnieBit(num<<9));
            Console.WriteLine(70&511);
            Console.ReadKey();
        }
    }
}
