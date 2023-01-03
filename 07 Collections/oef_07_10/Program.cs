using System;
using System.Collections.Generic;

namespace oef_07_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(LeesGetal($"Getal {i + 1}: "));
            }

            List<int> copy = new List<int>(list);
            copy.Sort();
            Console.WriteLine("\nHet middelste getal bevindt zich op positie {0} in de lijst.", list.IndexOf(copy[1]));

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
        private static int LeesGetal(string message)
        {
            string input;
            int getal;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }
    }
}
