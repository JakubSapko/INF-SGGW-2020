using System;

namespace Zad1
{
    abstract class Szyfr
    {
        protected int klucz;
        public Szyfr(int n)
        {
            klucz = n;
        }

        public abstract string Zaszyfruj(string o);

        public abstract string Odszyfruj(string o);

    }
    class SzyfrCezara : Szyfr
    {
        public SzyfrCezara(int n) : base(n) 
        {
        
        }
        public override string Zaszyfruj(string o) {
            char[] t = new char[o.Length];;
            for(int i = 0; i<o.Length; i++)
            {
                t[i] = (char)(o[i] + klucz);
            }
            return new string(t);
        }
        public override string Odszyfruj(string o) 
        { 
            char[] t = new char[o.Length];;
            for(int i = 0; i<o.Length; i++)
            {
                t[i] = (char) (o[i] - klucz);
            }
            return new string(t);
        }
    }
    class InnySzyfr : Szyfr
    {
        public InnySzyfr(int n) : base(n)
        {

        }
        public override string Zaszyfruj(string o)
        {
            char[] t = new char[o.Length]; ;
            for (int i = 0; i < o.Length; i++)
            {
                t[i] = (char)(o[i] ^ klucz);
            }
            return new string(t);
        }
        public override string Odszyfruj(string o)
        {
            char[] t = new char[o.Length]; ;
            for (int i = 0; i < o.Length; i++)
            {
                t[i] = (char)(o[i] ^ klucz);
            }
            return new string(t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SzyfrCezara szyfr = new SzyfrCezara(3);
            string x ="alamakota";
            Console.WriteLine(x);
            string z = szyfr.Zaszyfruj(x);
            Console.WriteLine(szyfr.Zaszyfruj(x));
            Console.WriteLine(szyfr.Odszyfruj(z));
            InnySzyfr szyf = new InnySzyfr(3);
            Console.WriteLine(x);
            string s = szyf.Zaszyfruj(x);
            Console.WriteLine(s);
            Console.WriteLine(szyf.Odszyfruj(s));
        }
    }
}
