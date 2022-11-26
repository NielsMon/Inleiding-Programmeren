using System;

namespace oef_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherm instellingen
            Console.Title = "Oefening 02.06";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal1, getal2, getal3, gem;
            string resultaat;

            // waarden inlezen
            Console.Write("Geef een eerste getal: ");
            getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef een tweede getal: ");
            getal2 = int.Parse(Console.ReadLine());
            Console.Write("Geef een derde getal: ");
            getal3 = int.Parse(Console.ReadLine());

            // berekeningen maken
            gem = (getal1 + getal2 + getal3) / 3;

            // selectie maken
            if (gem >= 50)
            {
                resultaat = "geslaagd";
            }
            else
            {
                resultaat = "niet geslaagd";
            }

            // resultaat printen
            Console.WriteLine($"{gem}, {resultaat}");

            // programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
