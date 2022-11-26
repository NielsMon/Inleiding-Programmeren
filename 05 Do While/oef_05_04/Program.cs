using System;

namespace oef_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 5: Oefening 4";

            // Variabelen declareren
            string zin = "Op de stoel ligt een zonnehoed en peperkoek";
            string antwoord = string.Empty;
            string poging = "pogingen";
            int teller = 0;

            // Bewerkingen uitvoeren
            Console.WriteLine(zin);
            Console.ReadLine();
            Console.Clear();

            do
            {
                Console.Write("Geef de zin: ");
                antwoord = Console.ReadLine();
                teller++;
            } while (zin != antwoord);

            if (teller == 1)
            {
                poging = "poging";
            }
            
            // Resultaat afdrukken
            Console.WriteLine($"Je had {teller} {poging} nodig!");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
