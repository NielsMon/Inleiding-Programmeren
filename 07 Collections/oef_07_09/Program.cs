using System;
using System.Collections.Generic;
using System.Linq;

namespace oef_07_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            List<int> list = CreateLevels();
            
            Console.WriteLine("Level\tPunten");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}\t{list[i]}");
            }
            Console.WriteLine();
            int som = SomErvaringspunten();
            Console.WriteLine($"Som = {som}");
            BepaalLevel(list, som);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 7: Oefening 7";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om verder te gaan!");
            Console.ReadLine();
        }
        private static List<int> CreateLevels()
        {
            List<int> levels = new List<int> { 50, 100, 200, 300, 400, 500, 600, 700, 900, 1000 };
            return levels;
        }
        private static int LeesGetal(string message)
        {
            int getal;
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }
        private static int SomErvaringspunten()
        {
            int som = 0, punten;
            string input;
            Console.Write("Geef ervaringspunten: ");
            input = Console.ReadLine();

            while (int.TryParse(input,out punten))
            {
                som += punten;
                Console.Write("Geef ervaringspunten: ");
                input = Console.ReadLine();
            };
            return som;
        }
        private static void BepaalLevel(List<int> levels, int som)
        {
            Console.WriteLine("\nJe hebt level {0} bereikt.", levels.FindIndex(level => level >= som));
        }
    }
}
