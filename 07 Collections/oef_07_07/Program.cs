using System;
using System.Collections.Generic;

namespace oef_07_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "appel", "peer", "paard", "ezel", "koffie", "thee", "water", "keuken", "badkamer", "frigo" };

            PasSchermkleurenAan();
            PrintLijst(list);
            StartTraining(list);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Title = "Les 7: Oefening 7";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om verder te gaan!");
            Console.ReadLine();
        }
        private static void PrintLijst(List<string> lijst)
        {
            foreach (var item in lijst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nENTER om de opdracht te starten!");
            Console.ReadLine();
            Console.Clear();
        }
        private static void StartTraining(List<string> lijst)
        {
            bool geraden;
            int counter = 0;
            string woord, output;

            do
            {
                Console.Write("woord: ");
                woord = Console.ReadLine();
                geraden = false ;
                foreach (var item in lijst)
                {
                    if (woord.ToLower() == item)
                    {
                        counter++;
                        geraden = true;
                    }
                }
            } while (geraden);
            if (counter == 1)
            {
                output = $"{counter} goed woord";
            }
            else
            {
                output = $"{counter} goede woorden";
            }
            Console.WriteLine($"Je hebt {output} geraden.");
        }
    }
}
