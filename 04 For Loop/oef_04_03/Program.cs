using System;

namespace oef_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.03";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // data opvragen
            Console.Write("Geef een positief getal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            for (int i = getal; i >= 1; i--)
            {
                Console.WriteLine(i*i);
            }

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
