using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace oef_10_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenaan();
            List<int> dubbels = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Werkt niet!");
            StopProgramma();
        }
        private static void PasSchermkleurenaan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 10";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static List<int> RemoveDubbels(List<int> dubbels)
        {
            
            for (int i = 0; i < dubbels.Count; i++)
            {
                for (int j = 1+i; j < dubbels.Count; j++)
                {
                    if (dubbels[i] == dubbels[j])
                    {
                        dubbels.RemoveAt(j);
                    }
                }
            }
            return dubbels;
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
