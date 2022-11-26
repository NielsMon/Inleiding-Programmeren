using System;

namespace oef_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string titel = "Les 05: Oefening 2";
            Console.Title = titel;

            Console.WriteLine(titel);
            Console.WriteLine(new String('_', titel.Length));


            // Variabelen declareren
            int aantal = 5;
            int totaal = 0;
            int prijs, lid, korting;
            bool succes;
            string input;

            // Data inlezen
            for (int i = 0; i < aantal; i++)
            {
                do
                {
                    Console.Write($"Prijs artikel {i +1}: ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out prijs);
                } while (!succes);
                totaal += prijs;
            }

            do
            {
                Console.Write("\nAantal jaren lid: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out lid);
            } while (!succes);

            // Bewerkingen uitvoeren
            switch (lid)
            {
                case 0: korting = 0; break;
                case 1: korting = 5; break;
                case 2: korting = 10; break;
                case 3: korting = 20; break;
                case 4: korting = 30; break;
                default: korting = 50;  break;
            }

            // Resultaat afdrukken
            Console.WriteLine($"\nTotaalprijs: {totaal-korting} euro");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
