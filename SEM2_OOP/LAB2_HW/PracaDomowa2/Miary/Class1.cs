using System;

namespace Miary
{
    public static class Ilość
    {
        public static double SztukiNaKopy(this double liczba_sztuk)
        {
            return liczba_sztuk / 60;
        }
        public static double SztukiNaTuziny(this double liczba_sztuk)
        {
            return liczba_sztuk / 12;
        }
        public static double SztukiNaMendle(this double liczba_sztuk)
        {
            return liczba_sztuk / 15;
        }
        public static double KopyNaSztuki(this double kopy)
        {
            return kopy * 60;
        }
        public static double TuzinyNaSztuki(this double tuziny)
        {
            return tuziny * 12;
        }
        public static double MendleNaSztuki(this double mendle)
        {
            return mendle * 15;
        }
    }
    public static class Długość
    {
        public static double MetryNaMilimetry(this double metry)
        {
            return metry * 1000;
        }
        public static double MilimetryNaCale(this double milimetry)
        {
            return milimetry / 25.4;
        }
        public static double MetryNaYardy(this double metry)
        {
            return metry / 0.9144;
        }
        public static double MetryNaMileMorskie(this double metry)
        {
            return metry / 1852;
        }
        public static double MetryNaMileAngielskie(this double metry)
        {
            return metry / 1609.344;
        }
        public static double MilimetryNaMetry(this double milimetry)
        {
            return milimetry / 1000;
        }
        public static double CaleNaMilimetry(this double cale)
        {
            return cale * 25.4;
        }
        public static double YardyNaMetry(this double yardy)
        {
            return yardy * 0.9144;
        }
        public static double MileMorskieNaMetry(this double mile_morskie)
        {
            return mile_morskie * 1852;
        }
        public static double MileAngielskieNaMetry(this double mile_angielskie)
        {
            return mile_angielskie * 1609.344;
        }
    }
    public static class Masa
    {
        public static double KilogramyNaGramy(this double kilogramy)
        {
            return kilogramy * 1000;
        }
        public static double KilogramyNaTony(this double kilogramy)
        {
            return kilogramy / 1000;
        }
        public static double KilogramyNaKwintale(this double kilogramy)
        {
            return kilogramy / 100;
        }
        public static double KilogramyNaFuntyBrytyjskie(this double kilogramy)
        {
            return kilogramy / 0.453592;
        }
        public static double GramyNaUncje(this double gramy)
        {
            return gramy / 28.35;
        }
        public static double GramyNaKilogramy(this double gramy)
        {
            return gramy / 1000;
        }
        public static double TonyNaKilogramy(this double tony)
        {
            return tony * 1000;
        }
        public static double KwintaleNaKilogramy(this double kwintale)
        {
            return kwintale * 100;
        }
        public static double FuntyBrytyjskieNaKilogramy(this double funty_brytyjskie)
        {
            return funty_brytyjskie * 0.453592;
        }
        public static double UncjeNaGramy(this double uncje)
        {
            return uncje * 28.35;
        }
    }
    public static class Temperetura
    {
        public static double CelsjuszaNaKelviny(this double celsjusza)
        {
            return celsjusza + 273.15;
        }
        public static double CelsjuszaNaFahrenheita(this double celsjusza)
        {
            return celsjusza * (9 / 5) + 32;
        }
        public static double KelvinyNaCelsjusza(this double kelviny)
        {
            return kelviny - 273.15;
        }
        public static double FahrenheitaNaCelsjusza(this double fahrenheita)
        {
            return (fahrenheita - 32) * (5 / 9);
        }
    }
    public static class Moc
    {
        public static double WatyNaKonieMechaniczne(this double waty)
        {
            return waty / 735.498;
        }
        public static double KonieMechaniczneNaWaty(this double konie_mechaniczne)
        {
            return konie_mechaniczne * 735.498;
        }
    }
    public static class Objętość
    {
        public static double MetrySześcienneNaLitry(this double metry_sześcienne)
        {
            return metry_sześcienne * 1000;
        }
        public static double LitryNaKwaterki(this double litry)
        {
            return litry * 4;
        }
        public static double LitryNaGalonyAngielskie(this double litry)
        {
            return litry / 4.5456;
        }
        public static double LitryNaMetrySześcienne(this double litry)
        {
            return litry / 1000;
        }
        public static double KwaterkiNaLitry(this double kwaterki)
        {
            return kwaterki / 4;
        }
        public static double GalonyAngielskieNaLitry(this double galony_angielskie)
        {
            return galony_angielskie * 4.5456;
        }
    }
}
