using System;

namespace oef_01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.Title = "Oefening 01.06";

            // variabelen declareren
            double lengte, omtrek, gewicht;

            // inlezen waarden
            Console.WriteLine("Geef uw lengte in cm: ");
            lengte = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef uw polsomtrek in cm: ");
            omtrek = double.Parse(Console.ReadLine());

            // berekeningen maken
            gewicht = (lengte + 4 * omtrek - 100) / 2;

            // resultaat afdrukken
            Console.WriteLine("Ideaal gewicht: {0} kilo", gewicht);

            // einde programma
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
