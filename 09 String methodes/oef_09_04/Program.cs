using System;

namespace oef_09_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            CreeerNieuwWoord(LeesWoord());
            
            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: Oefening 3";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string LeesWoord()
        {
            Console.Write("Woord: ");
            return Console.ReadLine();
        }
        private static void CreeerNieuwWoord(string woord)
        {
            Console.WriteLine($"Het nieuwe woord is {woord.Replace("o", "x")}");
        }
    }
}
