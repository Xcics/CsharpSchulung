using System;

namespace Inheritance
{
    public abstract class Möbel //abstrakte Basisklasse
    {
        public Möbel()
        {
            
        }

        public abstract void Montieren();
        public abstract void Benutzen();
        

        public decimal Preis { get; set; }
    }
}