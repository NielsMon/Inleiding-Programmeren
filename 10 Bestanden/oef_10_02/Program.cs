using System;
using System.IO;

namespace oef_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            LeesBestand(Console.ReadLine());
            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 2";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
        private static string PrintLine(int count, string symbol)
        {
            string line= string.Empty;
            for (int i = 0; i < count; i++)
            {
                line += symbol;
            }
            line += "\n";
            return line;
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
                        bool first = true;
                        string record = streamReader.ReadLine();
                        string[] data = record.Split(";");
                        output += $"Sjaal {data[0]}\n";
                        output += new string('*', $"Sjaal {data[0]}".Length) + "\n";
                        int length = int.Parse(data[3]);
                        int count = int.Parse(data[4]);

                        for (int i = 0; i < length; i++)
                        {
                            if (first)
                            {
                                output += PrintLine(count, data[1]);
                                first = false;
                            }
                            else
                            {
                                output += PrintLine(count, data[2]);
                                first = true;
                            }
                        }
                        output += "\n";
                    }

                    if (string.IsNullOrEmpty(output))
                    {
                        output = "Geen records.";
                    }


                    Console.WriteLine(output.Trim());
                }
            }
            else
            {
                Console.WriteLine($"{bestand} bestaat niet!");
            }

        }
    }
}
