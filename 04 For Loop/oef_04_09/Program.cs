using System;

namespace oef_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 4.09";

            // data opvragen
            Console.Write("Geef een positief getal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            int factor = 1;
            for (int i = 1; i <= getal; i++)
            {
                factor *= i;
            }
            Console.WriteLine(factor);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
