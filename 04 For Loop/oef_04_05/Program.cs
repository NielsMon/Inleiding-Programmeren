using System;

namespace oef_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 04.05";

            // data opvragen
            Console.Write("Geef eerste getal groter dan 1: ");
            int getalEen = int.Parse(Console.ReadLine());
            Console.Write("Geef een tweede getal kleiner dan het eerste: ");
            int getalTwee = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            string output = getalEen.ToString();
            for (int i = getalEen-1; i > getalTwee-1; i--)
            {
                output += " * " + i.ToString();
            }
            Console.WriteLine(output);

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
    }
}
