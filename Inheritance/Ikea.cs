using System;

namespace Inheritance
{
    internal class Ikea
    {
        public Ikea(string Standort)
        {
            StandortName = Standort;
            FilialUmsatz = 0;
        }

        public string StandortName { get; }
        public decimal FilialUmsatz { get; set; }

        public Möbel Verkaufen()
        {
            Console.WriteLine("Was möchten Sie kaufen");
            string eingabe = Console.ReadLine();
            Möbel möbel = null;
            switch (eingabe)
            {
                case "Tisch":
                    möbel = new Tisch();
                    break;
                case "Stuhl":
                    möbel = new Stuhl();
                    break;
                case "Schrank":
                    möbel = new Schrank();
                    break;
                default:
                    Console.WriteLine("Leider aus");
                    Console.ReadLine();
                    break;
            }
            if (möbel != null) { FilialUmsatz += möbel.Preis; }
            return möbel;
        }
    }
}