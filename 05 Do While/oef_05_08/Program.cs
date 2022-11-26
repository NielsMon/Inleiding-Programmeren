using System;

namespace oef_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 5: Oefening 8";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            int posGetal;
            int getal = 0;
            int som = 0;
            int teller = 0;

            // Data inlezen
            posGetal = leesPositiefGetal();

            // Bewerkingen uitvoeren
            do
            {
                getal++;
                som += getal;
                teller++;
            } while (som < posGetal);

            // Resultaat afdrukken
            Console.WriteLine($"Er zijn {teller} getallen nodig.");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }

        public static int leesPositiefGetal()
        {
            int getal;
            bool succes;
            string input;

            do
            {
                Console.Write("Geef een positief getal: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
                if (getal < 0)
                {
                    succes = false;
                    Console.WriteLine("Het gegeven getal is negatief!");
                }
            } while (!succes);

            return getal;
        }
    }
}
