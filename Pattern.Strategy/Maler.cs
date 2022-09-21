using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern.Strategy
{
    public class Maler : Arbeiter
    {
        public override void Arbeiten()
        {
            Console.WriteLine("Maler arbeitet");
        }
    }
}