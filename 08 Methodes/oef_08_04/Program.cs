using System;
using System.Collections.Generic;

namespace oef_08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            // Variabelen declareren
            List<int> hobbies = new List<int>();
            int hobby;
            bool stop = false;
            
            string tijdschrift;
            string output = string.Empty;

            // Gegevens inlezen
            ReadName("Familienaam: ");
            ReadName("Voornaam: ");

            Console.WriteLine("Hobby: ");
            Console.WriteLine("\t1 - Handwerk");
            Console.WriteLine("\t2 - Kleding maken");
            Console.WriteLine("\t3 - Interieur");
            Console.WriteLine("\t4 - Voetballen");
            Console.WriteLine("\t5 - Fietsen");
            Console.WriteLine("\t6 - Fotografie");
            Console.WriteLine("\t7 - Lopen");
            Console.WriteLine("\t8 - ...");

            hobby = ReadHobby(1, 8);
            if (hobby == 8)
            {
                stop = true;
            }
            else
            {
                hobbies.Add(hobby);
            }

            while (!stop)
            {
                hobby = ReadHobby(1, 8);
                if (hobby == 8)
                {
                    stop = true;
                }
                else
                {
                    hobbies.Add(hobby);
                }
            }

            // Resultaat afdrukken
            Console.Clear();
            RecommendedBooks(hobbies);

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 8: Oefening 4";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string ReadName(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
        private static int ReadHobby(int min, int max)
        {
            int getal;
            string input;
            do
            {
                Console.Write("Hobby: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }
        private static void RecommendedBooks(List<int> output)
        {
            string tijdschrift;

            if (output.Count == 0)
            {
                Console.WriteLine("Wij raden niets aan.");
            }
            else
            {
                foreach (var item in output)
                {
                    switch (item)
                    {
                        case 1: tijdschrift = "Anna"; break;
                        case 2: tijdschrift = "Knippie"; break;
                        case 3: tijdschrift = "VtWonen"; break;
                        case 4: tijdschrift = "Voetbal international"; break;
                        case 5: tijdschrift = "Wandelen & fietsen"; break;
                        case 6: tijdschrift = "Zoom NL"; break;
                        case 7: tijdschrift = "Runners"; break;
                        default: tijdschrift = "niets"; break;
                    }
                    Console.WriteLine($"Wij raden \"{tijdschrift}\" aan.");
                }
            }
        }
    }
}
