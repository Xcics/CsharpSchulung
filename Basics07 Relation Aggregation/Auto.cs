using System;

namespace Basics07_Relation_Aggregation
{
    public class Auto
    {
        private static int AnzahlAutos;
        static Auto() //statischer Konstruktor wird nur ein mal aufgerufen
        {
            AnzahlAutos = 0; //static: nur einmal für die gesamte Klasse
        }
        

        public Auto()
            : this("VW", 50)
        {
            
            
            
        }

        public Auto(string wunschmarke, int ps)
        {
            Marke = wunschmarke;
            Farbe = "Blau"; //Blau ist Ausprägung der Eigenschaft Farbe
            Tachostand = 0;
            Tankinhalt = 10;
            AnzahlAutos++;
            Fahrgestellnummer = AnzahlAutos;
            Motor = new Motor(ps);

            Räder = new Rad[4];
            for (int i = 0; i < 3; i++)
            {
                Räder[i] = new Rad();
            }
        }
        public string Marke { get; }
        public string Farbe { get; set; }
        public double Tachostand { get; private set; }
        public double Tankinhalt { get; private set; }
        public int Fahrgestellnummer { get; }
        public Motor Motor { get; set; }
        public Rad[] Räder { get; set; }

        public void Fahren(double strecke)
        {
            Motor.Anlassen();
            Tachostand += strecke;
            Tankinhalt -= strecke / 10;
            

            if (Tankinhalt <= 0)
            {
                throw new Exception("Tank leer");
            }
            Motor.Abschalten();

        }
        public void Anzeigen()
        {
            Console.WriteLine(ToString());
            Motor.Anzeigen();
            for (i <= Räder.Length())
            {
                Räder[i].Anzeigen();
            }
        }

        public string ToString()
        {
            string ergebnis = "Farbe: "+Farbe;
            ergebnis+="Marke: "+Marke;
            ergebnis+="Tachostand: "+Tachostand;
            ergebnis+="Tankinhalt: "+Tankinhalt;
            ergebnis+="Fahrgestellnummer: "+Fahrgestellnummer;
        }

    }
}