using System;

namespace oef_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 5: Oefening 3";

            // Variabelen declareren
            int passagiers = 0;
            int raamplaatsen = 0;
            string raam;
            bool succes;

            // Bewerkingen uitvoeren
            do
            {
                do
                {
                    Console.Write("Wilt u aan het raam zitten (Y/N)? ");
                    raam = Console.ReadLine().ToUpper();
                    switch (raam)
                    {
                        case "Y": succes = true; raamplaatsen++; passagiers++; break;
                        case "N": succes = true; passagiers++;  break;
                        default: succes = false; break;
                    }
                } while (!succes);
            } while (passagiers < 8 && raamplaatsen < 4);

            // Resultaat afdrukken
            Console.Clear ();
            Console.WriteLine($"Er zijn {passagiers} passagiers. {raamplaatsen} zitten er aan het raam.");

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
