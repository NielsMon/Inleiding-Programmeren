using System;
using System.Collections.Generic;

namespace oef_07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 1";

            // Variabelen declareren
            List<int> cijfers = new List<int>();
            int som = 0, teller = 0, getal;
            bool stop = false, succes = false;
            string input;

            // Data opvragen
            do
            {
                do
                {
                    Console.Write("Geef een cijfer: ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out getal);
                    if (input == String.Empty) { succes = true; }
                } while (!succes);

                if (input == String.Empty)
                {
                    stop = true;
                }
                else
                {
                    cijfers.Add(getal);
                }
            } while (!stop);

            // Bewerkingen uitvoeren
            foreach (var item in cijfers)
            {
                if (item < 0)
                {
                    som += item;
                }
                else if (item > 0)
                {
                    teller++;
                }
            }

            // Resultaat afdrukken
            Console.Clear ();
            Console.WriteLine($"Aantal positief: {teller}" +
                $"\nNegatieve som: {som}");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
