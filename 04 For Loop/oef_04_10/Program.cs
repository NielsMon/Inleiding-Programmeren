using System;

namespace oef_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 4.10";

            // data opvragen
            Console.Write("Geef een getal: ");
            int getalEen = int.Parse(Console.ReadLine());
            Console.Write("Geef een getal groter dan getal 1: ");
            int getalTwee = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            int som= 0;
            for (int i = getalEen + 1; i < getalTwee; i++)
            {
                if (i%10 == 0)
                {
                    som += i;
                }
            }
            Console.WriteLine("Som: {0}", som);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
