using System;

namespace oef_02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherm instellingen
            Console.Title = "Oefening 02.07";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int kleinste, getal;

            // getallen inlezen en controleren
            Console.Write("Geef een getal: ");
            kleinste = int.Parse(Console.ReadLine());

            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());
            if (getal < kleinste)
            {
                kleinste = getal;
            }

            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());
            if (getal < kleinste)
            {
                kleinste = getal;
            }
            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());
            if (getal < kleinste)
            {
                kleinste = getal;
            }

            // resultaat afdrukken
            Console.WriteLine($"Kleinste getal: {kleinste}");

            // programma afsluiten
            Console.WriteLine("\nDrukl ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
