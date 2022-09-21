using System;


namespace Basics_06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note:");
            int note = int.Parse(Console.ReadLine());
            string[] noten = { "sehr gut", "gut", "befriedigend", "ausreichend", "mangelhaft", "ungenügend" };
            try
            {
                Console.WriteLine(noten[note - 1]);
            }
            catch { Console.WriteLine("Fehler"); }
            Console.ReadLine();
        }
    }
}
