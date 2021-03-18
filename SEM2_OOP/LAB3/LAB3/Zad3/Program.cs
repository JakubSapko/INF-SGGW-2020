using System;
using System.Collections.Generic;

//Napisać klasę Samochód(rokProdukcji, marka, prędkośćMax, prędkość - pole protected)  
//    z konstruktorem i prostymi metodami(lub właściwościami) do odczytywania pól 
//    oraz do wyświetlania.Utworzyć klasę pochodną SamochódKierowany, 
//    która dodatkowo będzie zawierać metody Przyspiesz, Zwolnij.
//Napisać kolejną klasę pochodną SamochódUżytkowany z polem stanLicznika, 
//    kolor (wykorzystać typ wyliczeniowy), oraz dodać do niej odpowiednie 
//    konstruktory i metody(Pomaluj, Jedź). Napisać program ilustrujący.
class Samochod
{
    int rokProdukcji;
    string marka;
    int predkoscMax;
    protected int predkosc;

    public Samochod(int rok, string m, int max)
    {
        rokProdukcji = rok;
        marka = m;
        predkoscMax = max;
    }

    public void Start(int p)
    {
        predkosc = Math.Min(predkoscMax, p);
    }

    public void Stop()
    {
        predkosc = 0;
    }

    public void Stan()
    {
        Console.WriteLine(marka + " " + rokProdukcji + " " + predkosc);
    }
}
class SamochodKierowany : Samochod
{
    public SamochodKierowany(int rok, string m, int max) : base(rok, m, max)
    { }
    public void Przyspiesz()
    {

        Start(predkosc + 10);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Samochod s = new Samochod(2000, "Fiat", 140);
        s.Stan();
        s.Start(60);
        s.Stan();
        s.Stop();
        s.Stan();
        SamochodKierowany sk = new SamochodKierowany(2001, "Skoda", 150);
        sk.Przyspiesz();
        sk.Stan();
        sk.Przyspiesz();
        sk.Stan();
        sk.Przyspiesz();
        sk.Stan();

    }
}
