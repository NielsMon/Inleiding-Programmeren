using System;

namespace Les_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Les 4 : FOR Loop";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("For Loop");
            Console.WriteLine("________");

            // data opvragen
            Console.Write("Geef het aantal iteraties: ");
            int aantal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"{i}\t{i+1}");
            }

            string overzicht = "\n";
            for (int i = 0; i < aantal; i++)
            {
                overzicht += "\t" + aantal + "\n";
            }
            Console.WriteLine();
            Console.WriteLine(overzicht);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
