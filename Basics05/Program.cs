using System;


namespace Basics05
{
    class Program
    {
        static void Main()
        {
            //Geld
            Console.WriteLine("Geldinhalt");
            decimal geldbeutel = decimal.Parse(Console.ReadLine());

            //Einkaufen solange Geld>0
            while(geldbeutel > 0)
            {
                Console.WriteLine("Preis:");
                
                decimal preis = decimal.Parse(Console.ReadLine()); 
                geldbeutel = geldbeutel - preis;
                //Bei 0 abbruch
                if (preis == 0) { break; }
                //Preis abfragen, wenn zu groß Fehler
                if (geldbeutel <= 0) { Console.WriteLine("Pleite");
                                     Console.ReadLine();}
            }
                
        }
    }
}
