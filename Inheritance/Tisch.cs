using System;

namespace Inheritance
{
    public class Tisch : Möbel //Abgeleitete Klasse
    {
        public Tisch()
        {
            Preis = 100;
        }

        public override void Benutzen()
        {
            Console.WriteLine("Tisch wird benutzt");
            Console.ReadLine();
        }

        public override void Montieren()
        {
            Console.WriteLine("Tisch wird montiert");
            Console.ReadLine();
        }
    }
}