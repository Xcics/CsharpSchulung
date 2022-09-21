using System;

namespace Inheritance
{
    internal class Schrank : Möbel
    {
        public Schrank()
        {
            Preis = 300;
        }
        public override void Benutzen()
        {
            Console.WriteLine("Schrank wird benutzt");
            Console.ReadLine();
        }

        public override void Montieren()
        {
            Console.WriteLine("Schrank wird montiert");
            Console.ReadLine();
        }
    }
}