using System;

namespace oef_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 5: Oefening 7";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            int getal, resultaat;
            int score = 0;
            string input;

            // Data inlezen
            getal = geefGetal();

            // Bewerkingen uitvoeren
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"{i+1} * {getal} = ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out resultaat));

                if (resultaat == (i+1) * getal)
                {
                    score++;
                }
            }

            // Resultaat afdrukken
            Console.WriteLine($"U heeft {score}/10 behaald!");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }

        public static int geefGetal()
        {
            string input;
            int getal;

            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }


    }
}
