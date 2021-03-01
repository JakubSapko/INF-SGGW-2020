using System;

namespace Kontakt
{
    class Program
    {
        //Struktura Kontakt//
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
        static string ZwróćInformacje(Kontakt k)
        {
            return k.imie + " " + k.nazwisko + " " + k.numerTelefonu;
        }
        static void Edytuj(ref Kontakt k)
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
            k.imie = imie_podane;
            k.nazwisko = nazwisko_podane;
            k.numerTelefonu = numerTelefonu_podany;
        }

        //Struktura BazaKontaktów//
        struct BazaKontaktów
        {
            public Kontakt[] kontakty;
            public int licznik;

            public BazaKontaktów(int rozmiar)
            {
                licznik = 0;
                kontakty = new Kontakt[rozmiar];
            }
        }

        static void DodajDoBazy(ref BazaKontaktów baza, Kontakt k)
        {
            if (baza.licznik < baza.kontakty.Length)
            {
                baza.kontakty[baza.licznik] = k;
                baza.licznik++;
            }
            else
            {
                Kontakt[] bazakontaktów = new Kontakt[baza.licznik + 1];
                for(int i = 0; i<baza.licznik; i++)
                {
                    bazakontaktów[i] = baza.kontakty[i];
                }
                bazakontaktów[baza.licznik] = k;
                baza.licznik++;
                baza.kontakty = bazakontaktów;
            }
        }

        static void WypiszBazę(BazaKontaktów baza)
        {
            for(int i = 0; i<baza.licznik; i++)
            {
                Console.WriteLine(baza.kontakty[i]);
            }
        }

        static void UsuńZBazy(ref BazaKontaktów baza, int i)
        {
            Kontakt[] baza_nowa = new Kontakt[baza.licznik - 1];
            for(int j = 0; j<baza.licznik; j++)
            {
                if (j != i)
                {
                    baza_nowa[j] = baza.kontakty[j];
                }
                else
                {

                }
            }
            baza.licznik--;
            baza.kontakty = baza_nowa;
        }

        static int ZwróćIndeks(BazaKontaktów bazaKontaktów, string nazwisko, string imię)
        {
            for(int i = 0; i<bazaKontaktów.kontakty.Length; i++)
            {
                if (bazaKontaktów.kontakty[i].imie == imię && bazaKontaktów.kontakty[i].nazwisko == nazwisko)
                {
                    return i;
                }
            }
            return -1;
        }

        void UsuńZBazy(ref BazaKontaktów bazaKontaktów, string imię, string nazwisko)
        {
            Kontakt[] baza_nowa = new Kontakt[bazaKontaktów.licznik - 1];
            int indeks = ZwróćIndeks(bazaKontaktów, imię, nazwisko);
            for(int i = 0; i<bazaKontaktów.licznik; i++)
            {
                if (i != indeks)
                {
                    baza_nowa[i] = bazaKontaktów.kontakty[i];
                }
                else
                {

                }
            }
            bazaKontaktów.licznik--;
            bazaKontaktów.kontakty = baza_nowa;
        }

        static bool CzyIstniejeImie(BazaKontaktów bazaKontaktów, string imię)
        {
            for(int i = 0; i<bazaKontaktów.licznik; i++)
            {
                if(bazaKontaktów.kontakty[i].imie == imię)
                {
                    return true;
                }
            }
            return false;
        }
        static bool CzyIstniejeNazwisko(BazaKontaktów bazaKontaktów, string nazwisko)
        {
            for (int i = 0; i < bazaKontaktów.licznik; i++)
            {
                if (bazaKontaktów.kontakty[i].nazwisko == nazwisko)
                {
                    return true;
                }
            }
            return false;
        }
        static bool CzyIstniejeNumer(BazaKontaktów bazaKontaktów, int numer)
        {
            for (int i = 0; i < bazaKontaktów.licznik; i++)
            {
                if (bazaKontaktów.kontakty[i].numerTelefonu == numer)
                {
                    return true;
                }
            }
            return false;
        }

        static int IleKontatkow(BazaKontaktów bazaKontatków, string imię)
        {
            int counter = 0;
            for(int i = 0; i<bazaKontatków.licznik; i++)
            {
                if (bazaKontatków.kontakty[i].imie == imię)
                {
                    counter++;
                }
            }
            return counter;
        }

        static BazaKontaktów Kopiuj(BazaKontaktów bazaKontaktów)
        {
            Kontakt[] baza_nowa = new Kontakt[bazaKontaktów.licznik - 1];
            baza_nowa = bazaKontaktów.kontakty;
            return baza_nowa;
        }
        static void Main(string[] args)
        {

            
         
        }
    }
}
