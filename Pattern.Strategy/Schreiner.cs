using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern.Strategy
{
    public class Schreiner : Arbeiter
    {
        public override void Arbeiten()
        {
            Console.WriteLine("Schreiner arbeitet");
        }
    }
}