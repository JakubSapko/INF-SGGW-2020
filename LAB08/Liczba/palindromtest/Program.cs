using System;
using System.Linq;
using Palindromy;

namespace palindromtest
{
    class Program
    {

        static void Main(string[] args)
        {
            string test = "Ela - filut to dogoni";
            string test2 = "pies pies kot kot cebula";
            Console.WriteLine(test);
            Console.WriteLine(Palindrom.UsunZnaki(test));
            test = Palindrom.UsunPodwojneSpacje(Palindrom.UsunZnaki(test));
            Console.WriteLine(test);
            Console.WriteLine(Palindrom.IleWyrazow(test));
            string[] test_wyjscie = Palindrom.ZwrocTabliceWyrazow(test);
            for(int i = 0; i <Palindrom.IleWyrazow(test); i++)
            {
                Console.WriteLine(test_wyjscie[i]);
            }
            string[] test2_wyjscie = Palindrom.UsunDuplikaty(Palindrom.ZwrocTabliceWyrazow(test2));
            for (int j = 0; j < test2_wyjscie.Length; j++)
            {
                Console.WriteLine(test2_wyjscie[j]);
            }
        }
    }
}
