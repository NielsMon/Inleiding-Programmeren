using System;

namespace oef_09_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            PrintSter(LeesWoord());
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
            Console.WriteLine("Woord: ");
            return Console.ReadLine();
        }
        private static void PrintSter(string woord)
        {
            Console.WriteLine(new string('*', woord.Length));
        }
    }
}
