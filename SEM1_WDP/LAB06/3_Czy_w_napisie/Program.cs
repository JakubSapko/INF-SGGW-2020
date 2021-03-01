using System;

namespace RunCode
{
    class Program
    {
        static bool CzyWNapisie(string tekst, char znak)
        {
            for (int i=0; i<tekst.Length; i++)
            {
                if (tekst[i] == znak)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CzyWNapisieWhile(string tekst, char znak)
        {
            int i = 0;
            while(i<tekst.Length && tekst[i] != znak)
            {
                i++;
            }
            return Convert.ToBoolean((tekst.Length) - i);
        }
        static void Main(string[] args)
        {
            // przetestuj działanie programu
            Console.ReadKey();
        }
    }
}
