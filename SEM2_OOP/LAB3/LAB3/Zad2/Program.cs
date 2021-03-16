//Napisz klasę Rachunek do obsługi rachunku bankowego (rachunek może zawierać dane klienta). Następnie napisz kilka klas pochodnych:  RachunekOszczednosciowy(naliczają się odsetki), RachunekDebetowy(dopuszczony debet).Pamiętaj o odpowiednim zestawie konstruktorów. Napisz program ilustrujący, klasa Bank zawiera listę rachunków (do rozróżniania typu rachunku wykorzystaj operator as lub is).

using System;
using System.Collections.Generic;

public class Rachunek
{
    private int numer;
    protected double saldo = 0;

    public Rachunek(int numer)
    {
        this.numer = numer;
    }

    public bool Wplac(double kwota)
    {
        if (kwota <= 0) return false;
        saldo += kwota;
        return true;
    }

    public bool Wyplac(double kwota)
    {
        if (kwota <= 0 || kwota > saldo) return false;
        saldo -= kwota;
        return true;
    }


    public string Podaj()
    {
        return numer + " " + saldo;
    }
}

class RachunekOszczednosciowy : Rachunek
{
    double p;

    public RachunekOszczednosciowy(int nr, double p) : base(nr)
    {
        this.p = p;
    }
    public void Kapitalizacja()
    {
        saldo += saldo * p;
    }
 
}
class RachunekDebetowy : Rachunek
{
    double debet;
    public RachunekDebetowy(int nr, double debet) : base(nr)
    {
        this.debet = debet;
    }
    public bool Wyplac(double kwota)
    {
        if (kwota <= 0 || kwota > saldo+debet) return false;
        saldo -= kwota;
        return true;
    }

}
public class Bank
{
    List<Rachunek> rachunki = new List<Rachunek>();
    public void Podaj()
    {
        for (int i = 0; i<rachunki.Count; i++)
        {
            Console.WriteLine(rachunki[i].Podaj()); ;
        }
    }
    public void Dodaj(Rachunek r)
    {
        rachunki.Add(r);
    }
    public void Kapitalizuj()
    {
        for (int i = 0; i < rachunki.Count; i++)
        {
            if (rachunki[i] is RachunekOszczednosciowy) ((RachunekOszczednosciowy)rachunki[i]).Kapitalizacja();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rachunek r = new Rachunek(123);
        Console.WriteLine(r.Podaj());
        r.Wplac(500);
        Console.WriteLine(r.Podaj());
        r.Wplac(200);
        Console.WriteLine(r.Podaj());
        RachunekOszczednosciowy ro = new RachunekOszczednosciowy(321, 0.1);
        ro.Wplac(100);
        ro.Kapitalizacja();
        Console.WriteLine(ro.Podaj());
        RachunekDebetowy rd = new RachunekDebetowy(567, 200);
        rd.Wplac(300);
        Console.WriteLine(rd.Podaj());
        rd.Wyplac(400);
        Console.WriteLine(rd.Podaj());
        rd.Wyplac(400);
        Console.WriteLine(rd.Podaj());

        Bank b = new Bank();
        b.Dodaj(r);
        b.Dodaj(ro);
        b.Dodaj(rd);
        b.Podaj();
        b.Kapitalizuj();
        b.Podaj();
    }
}