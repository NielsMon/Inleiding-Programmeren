using System;

namespace oef_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.02";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // data opvragen
            Console.Write("Geef uw naam: ");
            string naam = Console.ReadLine();
            Console.Write("Geef uw geluksgetal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            string output = getal.ToString() + " ";
            for (int i = 0; i < getal; i++)
            {
                output += naam + " ";
            }
            Console.WriteLine(output);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
