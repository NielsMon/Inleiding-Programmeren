using System;
using System.IO;

namespace oef_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            LeesBestand(Console.ReadLine());
            Console.WriteLine();
            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: OEfening 1";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
        private static void LeesBestand(string bestand)
        {
            if (File.Exists(bestand))
            {
                using (StreamReader streamReader = new StreamReader(bestand))
                {
                    string output = string.Empty;
                    while (!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();
                        output += $"\n{record}";
                    }

                    if (!string.IsNullOrEmpty(output))
                    {
                        output = "Vrienden:" + output;
                    }
                    else
                    {
                        output = "Geen vrienden";
                    }
                    Console.WriteLine(output);
                }
            }
            else
            {
                Console.WriteLine($"{bestand} - bestand bestaat niet!");
            }
            
        }
    }
}
