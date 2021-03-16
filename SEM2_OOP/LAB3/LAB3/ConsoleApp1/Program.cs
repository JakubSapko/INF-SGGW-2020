using System;

//Zadanie 1
//A
//Wykorzystaj klasę Punkt do obsługi punktu na płaszczyźnie i 
//    utwórz klasy pochodne PunktKolorowy(dodatkowo przechowujemy kolor) oraz 
//    pochodną od punktu kolorowego PunktKolorowyOpisany, 
//    (która dodatkowo będzie zawierać opis). Napisać program ilustrujący.
//B
//Spróbuj zrobić odpowiednie wersje na strukturach z zawieraniem

class Punkt
{
    private double x;
    private double y;

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public Punkt(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public Punkt()
        : this(0, 0)
    {

    }
    public void Przesun(double d, double f)
    {
        x += d;
        y += f;
    }
    public void Wyswietl()
    {
        Console.WriteLine(x + " " + y);
    }

    // niestatyczne
    public double Odleglosc(Punkt p)
    {
        return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
    }

    public bool CzyIdentyczny(Punkt p)
    {
        return (x == p.x) && (y == p.y);
    }

    // statyczne, wykorzystujace juz zdefiniowane metody zwykle
    public static double Odleglosc(Punkt p1, Punkt p2)
    {
        return p1.Odleglosc(p2);
    }

    public static bool CzyIdentyczne(Punkt p, Punkt q)
    {
        return q.CzyIdentyczny(p);
    }
}
class PunktKolorowy : Punkt
{
    string kolor;
    public PunktKolorowy(string kolor, double x, double y) : base(x, y)
    {
        this.kolor = kolor;

    }
    public PunktKolorowy(string kolor)
    {
        this.kolor = kolor;
    }
    public void Wyswietl()
    {
        Console.WriteLine(kolor);
        base.Wyswietl();
    }
}
class PunktKolorowyOpisany : PunktKolorowy
{
    string opis = "";
    public PunktKolorowyOpisany(double x, double y, string kolor, string opis) : base(kolor, x, y)
    {
        this.opis = opis;
    }
    public void Wyswietl()
    {
        Console.WriteLine(opis);
        base.Wyswietl();
    }
}

class Program
{

    static void Main(string[] args)
    {
        PunktKolorowy b = new PunktKolorowy("czerwony", 1, 2);
        PunktKolorowy c = new PunktKolorowy("niebieski");
        Punkt r = new Punkt();
        Punkt p = new Punkt(1, 4);
        p.Wyswietl();
        Console.WriteLine(p.Odleglosc(r));
        b.Wyswietl();
        c.Wyswietl();
        Console.WriteLine(b.Odleglosc(r));
        Console.WriteLine(c.Odleglosc(r));
        Console.ReadKey();
    }
}
