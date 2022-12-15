using System;
using System.IO;

namespace oef_10_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            string output = string.Empty;
            int number;

            number = LeesBestandsnaam();

            while (number != 0)
            {
                output += LeesGedicht(number) + "\n\n";
                number = LeesBestandsnaam();
            }
            Console.Clear();
            if (!string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(output.Trim());
            }
            
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 4";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("Druk op enter om af te sluiten");
        }
        private static int LeesBestandsnaam()
        {
            string input;
            int number;
            do
            {
                Console.Write("Welk gedicht wil je lezen (0 = stop): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || number < 0);
            return number;
        }
        private static string LeesGedicht(int number)
        {
            string bestandsnaam = $"gedicht-{number}.txt";
            string output = string.Empty;

            if (File.Exists(bestandsnaam))
            {
                output = $"Gedicht {number}\n{new string('=', bestandsnaam.Length-4)}";
                using (StreamReader streamReader = new StreamReader(bestandsnaam))
                {
                    while (!streamReader.EndOfStream)
                    {
                        output += $"\n{streamReader.ReadLine()}";
                    }
                }
            }
            return output;
        }
    }
}
