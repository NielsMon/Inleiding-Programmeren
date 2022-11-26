using System;

namespace oef_08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            
            string familienaam = ReadName("Familienaam: ");
            string voornaam = ReadName("Voornaam: ");

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 8: Oefening 4";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string ReadName(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
    }
}
