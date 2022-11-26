using System;

namespace oef_06_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 5";

            // Variabelen declareren
            string output = string.Empty;
            string naam;
            int score;
            bool stop = false;
            int teller = 0;
            int som = 0;

            // Gegevens ingeven
            naam = vraagNaam();
            if (string.IsNullOrWhiteSpace(naam))
            {
                stop = true;
                score = 0;
            }
            else
            {
                score = vraagScore();
            }

            while (!stop)
            {
                teller++;
                som += score;
                if (string.IsNullOrWhiteSpace(output))
                {
                    output += $"{naam} ({score})";
                }
                else
                {
                    output += $"\n{naam} ({score})";
                }

                naam = vraagNaam();

                if (string.IsNullOrWhiteSpace(naam))
                {
                    stop = true;
                }
                else
                {
                    score = vraagScore();
                }
            }
            // Resultaat afdrukken
            if (!string.IsNullOrWhiteSpace(output))
            {
                Console.Clear();
                Console.WriteLine(output);
                Console.WriteLine($"Gemiddelde: {som / teller}");
            }

            // Stop programma
            Console.WriteLine("\nDruk ENTER om het programma te stoppen!");
            Console.ReadLine();
        }

        public static string vraagNaam()
        {
            string naam = string.Empty;

            Console.Write("Voornaam: ");
            naam =  Console.ReadLine();

            return naam;
        }

        public static int vraagScore()
        {
            int score;
            string input;

            do
            {
                Console.Write("Score: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out score));

            return score;
        }
    }
}
