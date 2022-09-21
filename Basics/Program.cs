using System;


namespace Basics04
{
    class Program
    {
        static void Main()
        {
            decimal umsatz = 1;
            do {
                
                try
                {
                    umsatz = decimal.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Fehler"); }

                
            }while (umsatz!=0);
                
                


            }

        }
    }
