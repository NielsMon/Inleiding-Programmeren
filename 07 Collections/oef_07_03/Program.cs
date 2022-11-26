using System;
using System.Collections.Generic;

namespace oef_07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 3";

            // Variabelen declareren
            int getal = 0, som = 0, teller = 0;
            bool stop = false, succes = false;
            string input = string.Empty;
            List<int> getallen = new List<int>();

            // Data opvragen
            input = geefGetal("Getal: ");
            if (input == string.Empty)
            {
                stop = true;
            }
            else
            {
                getal = int.Parse(input);
            }


            while (!stop)
            {
                getallen.Add(getal);
                teller++;
                som += getal;
                input = geefGetal("Getal: ");
                if (input == string.Empty)
                {
                    stop = true;
                }
                else
                {
                    getal = int.Parse(input);
                }
            }

            // Bewerkingen uitvoeren
            getallen.Sort();

            // Resultaat afdrukken
            Console.Clear();
            Console.WriteLine($"Laagste getal: {getallen[0]}" +
                $"\nHoogste getal: {getallen[getallen.Count - 1]}");

            
            // Programma sluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }

        public static string geefGetal(string opdracht)
        {
            string input;
            bool succes = false;
            int getal;
            do
            {
                Console.Write(opdracht);
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
                if (input == string.Empty)
                {
                    succes = true;
                }
            } while (!succes);

            return input;
        }
    }
}
