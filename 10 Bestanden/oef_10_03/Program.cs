using System;
using System.Collections.Generic;
using System.IO;

namespace oef_10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int keuze = LeesGetalMenu();
            switch (keuze)
            {
                case 1: GeefGemiddelde(LeesPunten(LeesBestandsnaam())); break;
                case 2: GeefMax(LeesPunten(LeesBestandsnaam())); break;
                case 3: GeefMin(LeesPunten(LeesBestandsnaam())); break;
            }
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 3";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
        private static int LeesGetalMenu()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een getal (1-3): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || number < 1 || number > 3);
            return number;
        }
        private static string LeesBestandsnaam()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een studentenbestand: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return $"studenten-{number}.txt";
        }
        private static List<int> LeesPunten(string bestandsnaam)
        {
            List<int> punten = new List<int>();
            if (File.Exists(bestandsnaam))
            {
                using(StreamReader streamReader = new StreamReader(bestandsnaam))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();
                        punten.Add(int.Parse(record));
                    }
                }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
            return punten;
        }
        private static void GeefGemiddelde(List<int> punten)
        {
            double som = 0;
            foreach (var item in punten)
            {
                som += item;
            }
            Console.WriteLine($"Het gemiddelde is {som / punten.Count}");
        }
        private static void GeefMax(List<int> punten)
        {
            double max = int.MinValue;
            foreach (var item in punten)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"De hoogste score is {max}");
        }
        private static void GeefMin(List<int> punten)
        {
            double min = int.MaxValue;
            foreach (var item in punten)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"De laagste score is {min}");
        }
    }
}
