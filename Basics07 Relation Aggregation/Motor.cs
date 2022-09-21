using System;


namespace Basics07_Relation_Aggregation
{
    public class Motor
    {

        public int Drehzahl { get; set; }
        public int Leistung { get; }

        public Motor(int ps)
        {
            Leistung = ps;
        }


        public void Anlassen()
        {
            Drehzahl = 1000;
        }

        public void Abschalten()
        {
            Drehzahl = 0;
        }

        public void Anzeigen()
        {
            Console.WriteLine(ToString());
        }

        public string ToString()
        {
            return "Leistung: "+Leistung;
        }
    }
}
