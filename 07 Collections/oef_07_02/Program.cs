using System;
using System.Collections.Generic;

namespace oef_07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 2";

            // Variabelen declareren
            bool succes = false, stop = false;
            string input;
            int getal, laagste = int.MaxValue, hoogste = int.MinValue, som = 0, teller = 0;
            List<int> cijfers = new List<int>();

            // Data opvragen

            do
            {
                Console.Write("Wil je een cijfer ingeven (ja/nee)? ");
                input = Console.ReadLine();

                if (input == "ja")
                {
                    do
                    {
                        Console.Write("Cijfer: ");
                        input = Console.ReadLine();
                        succes = int.TryParse(input, out getal);
                        if (input == string.Empty)
                        {
                            succes = true;
                        }
                    } while (!succes);
                    cijfers.Add(getal);
                }
                else if (input == "nee")
                {
                    stop = true;
                }
            } while (!stop);

            // Bewerkingen uitvoeren
            foreach (var item in cijfers)
            {
                teller++;
                som += item;
                
                if (item > hoogste)
                {
                    hoogste = item;
                }
                if (item < laagste)
                {
                    laagste = item;
                }
            }

            // Resultaat afdrukken
            Console.Clear ();
            Console.WriteLine($"Statistieken:" +
                $"\nLaagste cijfer: {laagste}" +
                $"\nHoogste cijfer: {hoogste}" +
                $"\nGemiddelde: {som/teller}");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
