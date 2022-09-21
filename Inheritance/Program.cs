using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ikea ikeaFrankfurt = new Ikea("Frankfurt");

            Möbel meinMöbel = ikeaFrankfurt.Verkaufen(); //Fabrikmethode Entwurfsmuster

            meinMöbel.Montieren(); // spätes Binden: zuerst zu Möbel, dann zu richtigem Objekt
            meinMöbel.Benutzen();
        }
    }
}
