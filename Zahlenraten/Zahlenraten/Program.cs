using System;


namespace Zahlenraten
{
    class Program
    {
        static void Main()
        {
            int geheimzahl = new Random().Next(1, 101);
            
            bool richtig = false;
            Console.WriteLine("Ihr Tipp");
            int tipp = int.Parse(Console.ReadLine());


            while (richtig == false)
            {
                
                if (tipp > geheimzahl) {
                    Console.WriteLine("Zu hoch");  Console.WriteLine("Neuer Tipp"); tipp = int.Parse(Console.ReadLine());
                }
                else if (tipp < geheimzahl) { Console.WriteLine("Zu niedrig");  Console.WriteLine("Neuer Tipp"); tipp = int.Parse(Console.ReadLine()); }
                else if (tipp == geheimzahl) { richtig = true; Console.WriteLine("Richtig"); Console.ReadLine(); }
                
            }
        }
    }
}
