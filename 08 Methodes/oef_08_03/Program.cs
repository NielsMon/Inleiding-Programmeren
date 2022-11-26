using System;
using System.Collections.Generic;

namespace oef_08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            List<int> punten = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                punten.Add(ReadNumber(1, 4));
            }
            Console.Clear();
            ShowScore(CalculateScore(punten));

            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 08: Oefening 3";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static int ReadNumber(int min, int max)
        {
            string input;
            int getal;
            do
            {
                Console.Write("Geef een getal (1 tot 4): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < 1 || getal > 4);
            return getal;
        }
        private static int CalculateScore(List<int> throws)
        {
            int som = 0;
            foreach (var item in throws)
            {
                switch (item)
                {
                    case 1: som += 0; break;
                    case 2: som += 20; break;
                    case 3: som += 50; break;
                    case 4: som += 100; break;
                }
            }
            return som;
        }
        private static void ShowScore(int score)
        {
            Console.WriteLine($"U hebt {score} punten behaald!");
        }
    }
}
