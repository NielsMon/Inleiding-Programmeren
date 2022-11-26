using System;

namespace oef_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 04.06";

            // data opvragen
            Console.Write("Geef eerste getal groter dan 1: ");
            int getalEen = int.Parse(Console.ReadLine());
            Console.Write("Geef een tweede getal kleiner dan het eerste: ");
            int getalTwee = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            string output = string.Empty;
            if (getalEen %2 == 0)
            {
                output = getalEen.ToString();
            }
            else
            {
                getalEen -= 1;
                output = getalEen.ToString();
            }
            for (int i = getalEen - 1; i > getalTwee - 1; i--)
            {
                if (i%2 == 0)
                {
                    output += " * " + i.ToString();
                }
            }
            Console.WriteLine(output);

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
