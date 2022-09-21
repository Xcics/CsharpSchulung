using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maler maler1 = new Maler();
            Maler maler2 = new Maler();

            Schreiner schreiner1 = new Schreiner();
            Schreiner schreiner2 = new Schreiner();

            Elektriker elektriker1 = new Elektriker();
            Elektriker elektriker2 = new Elektriker();

            Firma firma1 = new Firma("Maleriei");
            Firma firma2 = new Firma("Schreinerei");
            Firma firma3 = new Firma("Elektrobetrieb");

            firma1.Einstellen(maler1);
            firma1.Einstellen(maler2);

            firma2.Einstellen(schreiner1);
            firma2.Einstellen(schreiner2);

            firma3.Einstellen(elektriker1);
            firma3.Einstellen(elektriker2);

            firma1.Produzieren();
            firma2.Produzieren();
            firma3.Produzieren();

        }
    }
}
