using System;
using System.IO;

namespace Les_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            DrukTitel("Sportlijst");
            LeesBestand();
            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 10: Bestanden lezen";
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
        private static void LeesBestand()
        {
            string bestandsnaam = "sporten.txt";
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        Console.WriteLine(record); ;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} - bestand bestaat niet!");
            }
            
        }
    }
}
