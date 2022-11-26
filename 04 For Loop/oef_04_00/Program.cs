using System;

namespace oef_04_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.00";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // data opvragen
            Console.Write("Geef getal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getal + (i+1));
            }

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
