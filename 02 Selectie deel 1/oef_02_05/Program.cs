using System;

namespace oef_02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.Title = "Oefening 02.05";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal, punten;

            // waarden inlezen
            Console.Write("Geef de landingsplaats: ");
            getal = int.Parse(Console.ReadLine());

            // waarden controleren
            if (getal == 1)
            {
                punten = 0;
            }
            else if (getal == 2)
            {
                punten = 20;
            }
            else if (getal == 3)
            {
                punten = 50;
            }
            else
            {
                punten = 100;
            }

            // resultaat afdrukken
            Console.WriteLine($"{punten} punten.");

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
