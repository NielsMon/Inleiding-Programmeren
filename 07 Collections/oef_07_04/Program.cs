using System;
using System.Collections.Generic;

namespace oef_07_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 4";

            // Variabelen declareren
            List<string> woorden = new List<string>();
            string woord;
            bool stop = false;
            int langste = int.MinValue, kortste = int.MaxValue, indexKleinste = -1, indexLangste = -1;

            // Data opvragen
            woord = geefWoord("woord: ");
            if (woord == string.Empty)
            {
                stop = true;
            }
            while (!stop)
            {
                woorden.Add(woord);
                woord = geefWoord("woord: ");
                if (woord == string.Empty)
                {
                    stop = true;
                }
            }

            // Bewerkingen uitvoeren
            for (int i = 0; i < woorden.Count; i++)
            {
                if (woorden[i].Length < kortste)
                {
                    kortste = woorden[i].Length;
                    indexKleinste = i;
                }
                if (woorden[i].Length > langste)
                {
                    langste = woorden[i].Length;
                    indexLangste = i;
                }
            }


            // Resultaat afdrukken
            Console.Clear();
            if (woorden.Count == 0)
            {
                Console.WriteLine("Geen woorden in de lijst!");
            }
            else
            {
                Console.WriteLine($"Het langste woord is {woorden[indexLangste]}" +
                $"\nHet kortste woord is {woorden[indexKleinste]}" +
                $"\nDe som van de posities is {indexKleinste + indexLangste}");
            }
            
            

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string geefWoord(string vraag)
        {
            Console.Write(vraag);
            return Console.ReadLine();
        }
    }
}
