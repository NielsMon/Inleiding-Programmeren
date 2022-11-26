using System;

namespace oef_02_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // schermkleuren instellen
            Console.Title = "Oefening 02.00";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal;
            string resultaat;

            // getal inlezen
            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());

            // keuze maken
            if (getal < 0)
            {
                resultaat = "Negatief";
            }
            else
            {
                resultaat = "Positief";
            }

            // resultaat afdrukken
            Console.WriteLine(resultaat);

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
