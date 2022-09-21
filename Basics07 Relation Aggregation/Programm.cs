using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics07_Relation_Aggregation
{
    class Programm
    {
        public static void Main()
        {
            Auto Auto1 = new Auto();
            Auto Auto2 = new Auto("Porsche");
            try
            {
                Auto1.Fahren(20);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            Console.WriteLine(Auto1.Tankinhalt);
            Console.ReadLine();
        }
        
    }
}
