using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace oef_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenaan();
            for (int i = 0; i < 6; i++)
            {
                LeesBestand($"numbers-{i}.txt");
            }
            StopProgramma();
        }
        private static void PasSchermkleurenaan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 7";
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
            
            string output = "";
            //string[] array = new string[];
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        int som = 0;
                        string record = teLezenBestand.ReadLine();
                        string[] array = record.Split(';');
                        foreach (var item in array)
                        {
                            som += int.Parse(item);
                        }
                        if (string.IsNullOrWhiteSpace(output))
                        {
                            output = som.ToString();
                        }
                        else
                        {
                            output += $", {som}";
                        }
                    }
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
        }
    }
}
