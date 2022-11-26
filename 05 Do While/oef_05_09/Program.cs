using System;

namespace oef_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 5: Oefening 9";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            int eerste, tweede, deler;
            bool succes = false;

            // Data inlezen
            eerste = leesGetal();
            tweede = leesGetal();

            if (eerste >= 0 && tweede >= 0 && eerste < tweede)
            {
                deler = eerste;
            }
            else if (eerste >= 0 && tweede >= 0 && eerste > tweede)
            {
                deler = tweede;
            }
            else if (eerste < 0 && tweede < 0 && eerste < tweede)
            {
                deler = tweede;
            }
            else if (eerste < 0 && tweede < 0 && eerste > tweede)
            {
                deler = eerste;
            }
            else if (eerste >= 0 && tweede < 0)
            {
                deler = eerste;
            }
            else
            {
                deler = tweede;
            }

            // Bewerkingen uitvoeren
            do
            {
                if (eerste%deler == 0 && tweede%deler == 0)
                {
                    succes = true;
                }
                else
                {
                    deler--;
                }
            } while (!succes);

            // Resultaat afdrukken
            Console.WriteLine($"GGD is {deler}");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }

        public static int leesGetal()
        {
            int getal;
            string input;

            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));

            return getal;
        }
    }
}
