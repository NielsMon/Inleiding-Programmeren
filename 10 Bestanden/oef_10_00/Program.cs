using System;
using System.IO;

namespace oef_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenaan();
            // DrukTitel("Getallen 1");
            LeesBestand(Console.ReadLine());
            StopProgramma();
        }
        private static void PasSchermkleurenaan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Oefening 0";
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
            int som = 0;
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        som += int.Parse(record);
                    }
                    Console.WriteLine($"Som: {som}");
                }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }

        }
    }
}
