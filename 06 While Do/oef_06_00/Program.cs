using System;

namespace oef_06_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 1";

            // Variabelen declareren
            int getal = 1;
            int som = 0;
            bool succes = false;
            string input;

            // Input verzamelen
            

            while (getal > 0)
            {
                do
                {
                    Console.Write("Geef een getal (<=0 = exit): ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out getal);
                } while (!succes);

                if (getal > 0)
                {
                    som += getal;
                }
            }

            // Resultaat afdrukken
            Console.WriteLine($"Totaal: {som}");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om programma te sluiten!");
            Console.ReadLine();
        }
    }
}
