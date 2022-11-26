using System;

namespace oef_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 4.08";

            // data opvragen
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{getal} x {i} = {getal * i}");
            }

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
