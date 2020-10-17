using System;

namespace RunCode
{
    class Program
    {
        static bool CzyCyfra(char znak)
        {
            // tu dodaj swój kod
            if (znak>='0' && znak <= '9') { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            // tu wywołaj funkcję i sprawdź jej działanie
            Console.WriteLine(CzyCyfra('0'));;
            Console.WriteLine(CzyCyfra('1')); ;
            Console.WriteLine(CzyCyfra('2')); ;
            Console.WriteLine(CzyCyfra('3')); ;
            Console.WriteLine(CzyCyfra('4')); ;
            Console.WriteLine(CzyCyfra('5')); ;
            Console.WriteLine(CzyCyfra('6')); ;
            Console.WriteLine(CzyCyfra('7')); ;
            Console.WriteLine(CzyCyfra('8')); ;
            Console.WriteLine(CzyCyfra('9')); ;
            Console.WriteLine(CzyCyfra('/')); ;
            Console.WriteLine(CzyCyfra('c')); ;
            Console.WriteLine(CzyCyfra('H')); ;
            Console.WriteLine("Koniec programu!");
        }
    }
}
