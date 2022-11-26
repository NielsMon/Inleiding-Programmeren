using System;

namespace oef_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 5: Oefening 6";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            int getal, min, max, guess;
            int teller = 0;
            string input;
            bool succes;

            // Data inlezen
            do
            {
                Console.Write("Geef een getal kleiner of gelijk aan 100: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
                
                if (getal > 100)
                {
                    succes = false;
                }
            } while (!succes);

            // Bewerkingen uitvoeren
            min = getal - 10;
            max = min + 10;
            do
            {
                teller++;
                Console.Write($"U kan gokken in de range van {min} tot {max}: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out guess);

                if (guess != getal)
                {
                    succes = false;
                }
            } while (!succes);

            // Resultaat afdrukken
            Console.WriteLine($"Je hebt {teller} keer geraden!");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
