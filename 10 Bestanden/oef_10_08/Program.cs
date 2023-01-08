using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace oef_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenaan();
            LeesBestand("kwadraten-1.txt");
            Console.WriteLine("Werkt niet");
            StopProgramma();
        }
        private static void PasSchermkleurenaan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 8";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static void DrukTitel(string titel)
        {
            Console.WriteLine(titel);
            Console.WriteLine(new String('*', titel.Length));
        }
        private static void LeesBestand(string bestandsnaam)
        {
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        string[] array = record.Split(';');
                    }
                }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
        }
    }
}
