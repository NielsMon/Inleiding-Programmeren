using System;

namespace oef_06_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 6: Oefening 6";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            int aantal;
            int som = 0;
            bool stop = false;
            bool succes = false;
            string input;

            // Data inlezen en bewerken
            while (!stop)
            {
                do
                {
                    Console.Write("Aantal tickets: ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out aantal);
                    if (input == string.Empty)
                    {
                        stop = true;
                        succes = true;
                    }
                } while (!succes);
                som += aantal;
            }

            if (som < 0)
            {
                som = 0;
            }

            // Resultaat afdrukken
            Console.WriteLine($"\nTotaal aantal tickets: {som}");
            Console.WriteLine($"Totale prijs: {som * 15}");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
