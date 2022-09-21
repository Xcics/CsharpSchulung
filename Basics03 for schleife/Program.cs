using System;


namespace Basics04
{
    class Program
    {
        static void Main()
        {
            decimal gesamt = 0;
            for (int i = 1; i <=12; i++)
            {
                

                string monat = "Test";

                switch (i)
                {
                    case 1: 
                        monat = "Januar";
                        break;
                    case 2: 
                        monat = "Februar";
                        break ;
                    case 3: 
                        monat = "März";
                        break;
                    case 4:
                        monat = "April";
                        break;
                    case 5:
                        monat = "Mai";
                        break;
                    case 6:
                        monat = "Juni";
                        break;
                    case 7:
                        monat = "Juli";
                        break;
                    case 8:
                        monat = "August";
                        break;
                    case 9:
                        monat = "September";
                        break;
                    case 10:
                        monat = "Oktober";
                        break;
                    case 11:
                        monat = "November";
                        break;
                    case 12:
                        monat = "Dezember";
                        break;
                }
                Console.WriteLine(monat+":");
                decimal umsatz = 0;
                try
                {
                    umsatz = decimal.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Fehler"); }
                gesamt = gesamt+umsatz;

                    
            }
            
        }
    }
}
