using System;

namespace oef_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.Title = "Oefening 02.04";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal;

            // waarden inlezen
            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());

            // waarden controleren
            if (getal%5==0 && getal%11==0)
            {
                Console.WriteLine("Deelbaar.");
            }else
            {
                Console.WriteLine("Niet deelbaar.");
            }

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
