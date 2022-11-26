using System;

namespace oef_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.01";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // bewerkingen
            int som = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Geef een getal: ");
                som += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Som: {0}", som);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
