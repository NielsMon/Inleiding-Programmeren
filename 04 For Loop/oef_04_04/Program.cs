using System;

namespace oef_04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.04";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // data opvragen
            Console.Write("Geef een symbool: ");
            string symbEen = Console.ReadLine();
            Console.Write("Geef een symbool: ");
            string symbTwee = Console.ReadLine();
            Console.Write("Geef een lengte: ");
            int lengte = int.Parse(Console.ReadLine());
            Console.Write("Geef een breedte: ");
            int breedte = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            bool isEen = true;
            string output;
            for (int i = 0; i < lengte; i++)
            {
                if (isEen)
                {
                    for (int j = 0; j < breedte; j++)
                    {
                        Console.Write(symbEen);
                    }
                    isEen = false;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < breedte; j++)
                    {
                        Console.Write(symbTwee);
                    }
                    isEen = true;
                    Console.WriteLine();
                }
            }

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
