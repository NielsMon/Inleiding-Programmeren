using System;

namespace oef_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een x coordinaat: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef een y coordinaat: ");
            int getal2 = int.Parse(Console.ReadLine());

            if (getal1 >= 0 && getal2 >= 0)
            {
                if (getal1 == 0 && getal2 == 0)
                {
                    Console.WriteLine("Punt ligt in de oorsprong.");
                }
                else
                {
                    Console.WriteLine("Punt ligt in het eerste kwadrant.");
                }
            }
            else if (getal1 < 0 && getal2 >= 0)
            {
                Console.WriteLine("Punt ligt in het tweede kwadrant.");
            }else if (getal1 < 0 && getal2 < 0)
            {
                Console.WriteLine("Punt ligt in het derde kwadrant.");
            }
            else
            {
                Console.WriteLine("Punt ligt in het vierde kwadrant.");
            }
        }
    }
}
