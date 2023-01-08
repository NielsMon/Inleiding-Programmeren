using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace oef_10_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenaan();
            for (int i = 0; i < 6; i++)
            {
                LeesBestand($"isogram-{i}.txt");
            }
            StopProgramma();
        }
        private static void PasSchermkleurenaan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 9";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static bool IsIsogram(string word)
        {
            bool isogram = true;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 1+i; j < word.Length; j++)
                {
                    if (word.Substring(i, 1) == word.Substring(j, 1))
                    {
                        isogram = false; break;
                    }
                }
            }
            return isogram;
        }
        private static void LeesBestand(string bestandsnaam)
        {
            if (File.Exists(bestandsnaam))
            {
                int counter = 0;
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        if (IsIsogram(record))
                        {
                            counter++;
                        }
                    }
                }
                string isogram = counter == 1 ? "isogram" : "isogrammen";
                Console.WriteLine($"{counter} {isogram} gevonden");
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
        }
    }
}
