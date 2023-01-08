using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace oef_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            List<string> list = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"p-{i}.txt: ");
                LeesBestand($"p-{i}.txt");
            }
            EndProgram();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 10: Oefening 6";
        }
        private static void EndProgram()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static void LeesBestand(string bestandsnaam)
        {
            string output;
            List<string> list = new List<string>();
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        list.Add(record);
                    }
                }
                NamenUitlezen(list);
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
        }
        private static void NamenUitlezen(List<string> list)
        {
            string output;
            switch (list.Count)
            {
                case 1: output = $"{list[0]} vindt "; break;
                case 2: output = $"{list[0]} en {list[1]} vinden "; break;
                case 3: output = $"{list[0]}, {list[1]} en {list[2]} vinden "; break;
                case 4: output = $"{list[0]}, {list[1]} en 2 anderen vinden "; break;
                default: output = "Niemand vindt "; break;
            }
            output += "dit leuk.";
            Console.WriteLine(output);
        }
    }
}
