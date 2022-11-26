using System;

namespace oef_06_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 6: Oefening 9";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            string naam, input;
            DateTime geboorteDatum;
            bool binnenKat;
            bool stop = false;

            // Data  en verwerken
            while (!stop)
            {
                Console.Write("Naam kat: ");
                naam = Console.ReadLine();

                do
                {
                    Console.Write("Geboortedatum (jjjj/mm/dd): ");
                    input = Console.ReadLine();
                } while (!DateTime.TryParse(input, out geboorteDatum));

                if (DateTime.Now-geboorteDatum <=1)
                {

                }
                do
                {
                    Console.Write("Binnenkat (true/false): ");
                    input = Console.ReadLine();
                } while (!bool.TryParse(input, out binnenKat));

                Console.WriteLine($"{naam} is een {}");

            }

            // Resultaat afdrukken
            
            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
