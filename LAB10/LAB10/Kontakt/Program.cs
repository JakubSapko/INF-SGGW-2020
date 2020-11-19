using System;

namespace Kontakt
{
    class Program
    {
        public struct Kontakt
        {
            public string imie;
            public string nazwisko;
            public int numerTelefonu;
            private string tajneDane;
            private int PIN;

            public int pin { 
                get => PIN;
                set
                {
                    PIN = value;
                }
            }

            public string tajne
            {
                get => tajneDane;
                set
                {
                    tajneDane = value;
                }
            }
            public Kontakt(string imie, string nazwisko, int numerTelefonu, string tajneDane, int PIN)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.numerTelefonu = numerTelefonu;
                this.tajneDane = tajneDane;
                this.PIN = PIN;
            }
            public string ZwróćInformacje()
            {
                return imie + " " + nazwisko + " " + numerTelefonu;
            }

            public void Edytuj()
            {
                string imie_podane;
                string nazwisko_podane;
                int numerTelefonu_podany;
                Console.WriteLine("Podaj imie:");
                imie_podane = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko:");
                nazwisko_podane = Console.ReadLine();
                Console.WriteLine("Podaj numer telefonu:");
                numerTelefonu_podany = Convert.ToInt32(Console.ReadLine());
                imie = imie_podane;
                nazwisko = nazwisko_podane;
                numerTelefonu = numerTelefonu_podany;
            }

            public bool Autoryzuj(int PIN)
            {
                if(this.PIN == PIN) { return true; }
                else { return false; }
            }

            public string ZwróćTajne(int PIN)
            {
                if (Autoryzuj(PIN))
                {
                    return tajne;
                }
                else
                {
                    return "Podany PIN jest nieprawidłowy.";
                }
            }

            public bool ZmieńPIN(int PIN, int nowyPIN)
            {
                if (Autoryzuj(PIN))
                {
                    this.PIN = nowyPIN;
                    Console.WriteLine("PIN został zmieniony");
                    return true;
                }
                else
                {
                    Console.WriteLine("PIN nie został zmieniony");
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Kontakt my = new Kontakt();
            my.Edytuj();
            my.pin = 1234;
            my.tajne = "pies";
            Console.WriteLine(my.ZwróćInformacje());
            Console.WriteLine(my.Autoryzuj(1234));
            my.ZmieńPIN(1234, 5235);
            Console.WriteLine(my.Autoryzuj(1234));
            Console.WriteLine(my.Autoryzuj(5235));
            Console.WriteLine(my.ZwróćTajne(5235));
        }
    }
}
