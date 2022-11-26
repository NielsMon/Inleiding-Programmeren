using System;

namespace oef_01_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // console declareren
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "Oefening 01.08";

            // variabelen declareren
            double straal, omtrek;

            // waarden opvragen
            Console.WriteLine("Geef de straal van een cirkel: ");
            straal = int.Parse(Console.ReadLine());

            // berekeningen maken
            omtrek = 2 * straal * 3.14;

            // waarden afdrukken
            Console.WriteLine($"Omtrek: {omtrek}");

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();

            Console.Title = "01 Sequentie - oplossing 08";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            */

            // Declaratie
            double straal, omtrek;

            // Inlezen
            straal = int.Parse(Console.ReadLine());

            // Berekenen
            omtrek = straal * 2 * 3.14;

            // Afdrukken
            Console.WriteLine($"Omtrek: {omtrek:N2}");

            Console.ReadLine();
        }
    }
}
