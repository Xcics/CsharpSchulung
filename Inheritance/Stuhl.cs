using System;

namespace Inheritance
{
    internal class Stuhl : Möbel
    {
        public Stuhl()
        {
            Preis = 50;
        }
        public override void Benutzen()
        {
            Console.WriteLine("Stuhl wird benutzt");
            Console.ReadLine();
        }

        public override void Montieren()
        {
            Console.WriteLine("Stuhl wird montiert");
            Console.ReadLine();
        }
    }
}