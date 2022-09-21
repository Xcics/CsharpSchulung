using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basics07_Relation_Aggregation
{
    public class Rad
    {
        public double Luftdruck { get; set; }  

        public Rad()
        {
            Luftdruck = 2.0
        }

        public void Anzeigen()
        {
            Console.WriteLine(ToString());
        }

        public string ToString()
        {

        }
    }
}