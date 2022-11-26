using System;

namespace oef_07_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 5";

            // Variabelen declareren
            bool succes = false;
            string input = string.Empty;
            int getal, teller = 0, kleinste = int.MaxValue, grootste = int.MinValue, som = 0;

            // Data inlezen
            do
            {
                Console.Write("Getal: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
            } while (!succes);

            while (getal != 0)
            {
                teller++;
                som += getal;

                if (getal < kleinste)
                {
                    kleinste = getal;
                }
                if (getal > grootste)
                {
                    grootste = getal;
                }

                do
                {
                    Console.Write("Getal: ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out getal);
                } while (!succes);
            }

            // Resultaat afdrukken
            Console.Clear ();
            Console.WriteLine($"Statistieken:" +
                $"\nHoogste cijfer: {grootste}" +
                $"\nLaagste cijfer: {kleinste}" +
                $"\nGemiddelde: {som/teller}");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
