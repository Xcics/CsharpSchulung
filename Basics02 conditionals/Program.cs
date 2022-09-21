using System;


namespace Basics02_conditionals
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Dies ist ein Tool zur Umwandlung von Zahlen in Textnoten. Zum Abbrechen bitte Note 7 eingeben Bitte Note eingeben:");
            int note = int.Parse(Console.ReadLine());
            
                switch (note)
                {
                    case 1:
                        Console.WriteLine("Sehr gut");
                        break;
                    case 2:
                        Console.WriteLine("gut");
                        break;
                    case 3:
                        Console.WriteLine("befriedigend");
                        break;
                    case 4:
                        Console.WriteLine("ausreichend");
                        break;
                    case 5:
                        Console.WriteLine("ungenügend");
                        break;
                    case 6:
                        Console.WriteLine("mangelhaft");
                        break;
                    default:
                        Console.WriteLine("falsche Eingabe");
                        break;

                }
                Console.ReadLine();
                
            
            
        }
    }
}
