using System;

namespace oef_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 5: Oefening 5";

            // Variabelen declareren
            int landingsplaats;
            int totaal = 0;
            int pijlen = 3;
            string input;
            bool isInt = false;
            bool isScore = false;
            bool isSucces = false;


            // Bewerkingen uitvoeren
            for (int i = 0; i < pijlen; i++)
            {
                // Controle input
                do
                {
                    Console.Write("Landingsplaats pijl {0} (1, 2, 3, 4): ", i+1);
                    input = Console.ReadLine();
                    isInt = int.TryParse(input, out landingsplaats);
                    if (landingsplaats >= 1 && landingsplaats <=4)
                    {
                        isScore = true;
                    }
                } while (!isInt || !isScore);

                switch (landingsplaats)
                {
                    case 1: totaal += 0; break;
                    case 2: totaal += 20; break;
                    case 3: totaal += 50; break;
                    case 4: totaal += 100; break;
                }
            }

            // Resultaat afdrukken
            Console.WriteLine($"U hebt {totaal} punten behaald");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
