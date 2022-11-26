using System;

namespace oef_05_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 5: Oefening 10";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            string input = string.Empty;
            string output = string.Empty;
            string temp = string.Empty;
            bool stop = false;

            // Data inlezen en bewerken
            do
            {
                temp = output;
                Console.Write("Input: ");
                input = Console.ReadLine();
                output = input + "\n" + temp;
            } while (input != "stop");

            // Resultaat afdrukken
            Console.WriteLine();
            Console.WriteLine(output);

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
