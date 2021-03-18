using System;
using System.Collections.Generic;


namespace Zad4
{
    class Pies
    {
        string imie;
        int wiek;
        protected string siersc = "krótka";
        protected string rasa = "kundel";

        public Pies(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
        public string Imie
        {
            get => imie;
            set
            {
                imie = value;
            }
        }
        public int Wiek
        {
            get => wiek;
            set
            {
                if ((value>0) && (value < 30))
                {
                    wiek = value;
                }
            }
        }

        public void OdczytajRase()
        {
            Console.WriteLine(rasa);
        }
        public void ZmienRase(string rasa)
        {
            this.rasa = rasa;
        }
        public void OdczytajSiersc()
        {
            Console.WriteLine(siersc);
        }
        public void ZmienSiersc(string siersc)
        {
            this.siersc = siersc;
        }

        public void OdczytajPsa()
        {
            Console.WriteLine("Oto pies");
            Console.WriteLine("{0}, {1}, {2}, {3}", imie, wiek, siersc, rasa);
        }
    }
    
    class PiesRasowy : Pies
    {
        List<string> listaNagrod;

        public PiesRasowy(string imie, int wiek, List<string> listaNagrod) : base(imie, wiek)
        {
            this.listaNagrod = listaNagrod;
        }
        public void DodajNagrode(string nagroda)
        {
            listaNagrod.Add(nagroda);
        }
        public void WyswietlNagrody()
        {
            for (int i = 0; i<listaNagrod.Count; i++)
            {
                Console.WriteLine(listaNagrod[i]);
            }
        }
    }
    class Chart : PiesRasowy
    {
        double predkosc;

        public Chart(string imie, int wiek, List<string> listaNagrod) : base(imie, wiek, listaNagrod)
        {
          
        }
        public Chart(string imie, int wiek, List<string> listaNagrod, double predkosc) : base(imie, wiek, listaNagrod)
        {
            this.predkosc = predkosc;
        }
        public void OdczytajPredkosc()
        {
            Console.WriteLine(predkosc);
        }
        public void Biegnij(double p)
        {
            if (predkosc <= 0)
            {
                predkosc = p;
            }
            else { }
        }
        public void Stoj()
        {
            predkosc = 0;
        }
        public void FryzujSiersc(string siersc)
        {
            this.siersc = siersc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zwykly pies
            Pies pies = new Pies("Burek", 3);
            pies.OdczytajPsa();
            pies.OdczytajRase();
            pies.ZmienRase("Owczarek");
            pies.OdczytajRase();
            Console.WriteLine(pies.Wiek);
            pies.Wiek = 5;
            Console.WriteLine(pies.Wiek);
            //Pies rasowy
            List<string> nagrody = new List<string> { };
            nagrody.Add("brawo");
            PiesRasowy piesr = new PiesRasowy("Fryderyk", 4, nagrody);
            piesr.WyswietlNagrody();
            //Chart
            Chart chart = new Chart("Adam", 2, nagrody, 2.0);
            Chart chart2 = new Chart("Jan", 2, nagrody);
            chart.FryzujSiersc("długa");
            chart.OdczytajPsa();
        }
    }
}
