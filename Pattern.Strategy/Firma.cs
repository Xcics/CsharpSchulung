using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern.Strategy
{
    public class Firma
    {
        public Firma(string firmennname)
        {
        Name = firmennname;
            Gehaltsliste = new List<Arbeiter>();
        }

        public string Name {get; set; }
        public List<Arbeiter> Gehaltsliste { get; set; }
        public Arbeiter Arbeiter {get; set; }

        public void Produzieren()
        {
            foreach (Arbeiter arbeiter in Gehaltsliste) { arbeiter.Arbeiten(); 
                Console.WriteLine("Fertig produziert"); 
                Console.ReadLine();
            }
        }

        public void Einstellen(Arbeiter arbeiter)
        {
            Gehaltsliste.Add(arbeiter);
        }

        public void Entlassen(Arbeiter arbeiter)
        {
            Gehaltsliste.Remove(arbeiter);       
         }
    }
    }
