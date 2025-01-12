using System;

namespace ConsoleApp_12._01._2025
{
    //zad.1
    public class Zwierze
    {
        // Metoda wirtualna z domyślną implementacją
        public virtual void WydajDzwiek()
        {
            Console.WriteLine("Zwierze wydaje ogólny dźwięk.");
        }
    }

    public class Pies : Zwierze
    {
        // Nadpisanie
        public override void WydajDzwiek()
        {
            Console.WriteLine("Pies wydaje dźwięk: hau");
        }
    }

    //zad.2
    public class Figura
    {
        protected double Powierzchnia; //zmienna chroniona

        public virtual void OblPowierzchnie()
        {
            Console.WriteLine("Obliczanie pola powierzchni: ");
        }
        public double GetPowierzchnia() //uzyskanie wartosci powierzchni
        {
            return Powierzchnia;
        }


    }

    public class Kolo : Figura
    {
        private double promien;

        public Kolo(double promien)
        {
            this.promien = promien;
        }

        public override void OblPowierzchnie()
        {
            Powierzchnia = Math.PI * Math.Pow(promien, 2);
            Console.WriteLine($"Powierzchnia kola o r= {promien} wynosi: {Powierzchnia}");
        }

    }
    public class Kwadrat : Figura
    {
        private double bok;

        public Kwadrat(double bok)
        {
            this.bok = bok;
        }

        public override void OblPowierzchnie()
        {
            Powierzchnia = Math.Pow(bok, 2);
            Console.WriteLine($"Powierzchnia kwadratu o boku= {bok} wynosi: {Powierzchnia}");
        }
    }

    //zad.3
    /*
     * Klasa generyczna - może działać na różnych typach danych, określanych w momencie tworzenia instancji danej klasy.
     * Umożliwia pisanie kodu wielokrotnego użytku, niezwiązanego z konkretnym typem danych.
     * Metoda generyczna - pozwala na definiowanie operacji, mogących być zastosowanych do różnych typów danych.
     **/

    //zad.4 
    public class Lekcja
    {
        public string Przedmiot { get; set; }
        public string DzienTyg { get; set; }
        public TimeSpan GodzRozpoczecia { get; set; }

        //przedmiot i dzien tyg
        public Lekcja(string przedmiot, string dzienTyg)
        {
            Przedmiot = przedmiot;
            DzienTyg = dzienTyg;
            GodzRozpoczecia = new TimeSpan(6, 0, 0); //domyslna godz ropoczecia
        }

        //przedmiot, dzien tyg, godz rozpoczecia
        public Lekcja(string przedmiot, string dzienTyg, TimeSpan godzRozpoczecia)
        {
            Przedmiot = przedmiot;
            DzienTyg = dzienTyg;
            GodzRozpoczecia = godzRozpoczecia;
        }

        //konstruktor bezparametrowy
        public Lekcja()
        {
            Przedmiot = "Brak";
            DzienTyg = "Poniedzialek";
            GodzRozpoczecia = new TimeSpan(8, 0, 0); //domyslna godz rozpoczecia
        }

        //wyswietlanie info o lekcji
        public void WyswietlInfo()
        {
            Console.WriteLine($"Przedmiot: {Przedmiot}, Dzien: {DzienTyg}, Godz: {GodzRozpoczecia}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //zad.2 cd
            //tworzenie obiektow
            Kolo kolo = new Kolo(6);
            Kwadrat kwadrat = new Kwadrat(4);

            //obl powierzchni
            kolo.OblPowierzchnie();
            kwadrat.OblPowierzchnie();

            //zad.4 cd
            Lekcja lekcja1 = new Lekcja("Matematyka", "Wtorek");
            Lekcja lekcja2 = new Lekcja("Fizyka", "Czwartek", new TimeSpan(10, 30, 0));
            Lekcja lekcja3 = new Lekcja();

            // Wyświetlanie informacji o lekcjach
            lekcja1.WyswietlInfo();
            lekcja2.WyswietlInfo();
            lekcja3.WyswietlInfo();

        }
    }
}
