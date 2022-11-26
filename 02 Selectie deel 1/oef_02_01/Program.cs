using System;

namespace oef_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // schermkleuren aanpassen
            Console.Title = "Oefening 02.01";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal1, getal2;

            // waarden inlezen
            Console.Write("Geef een getal: ");
            getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef een tweede getal: ");
            getal2 = int.Parse(Console.ReadLine());

            // vergelijkingen maken
            if (getal1 > getal2)
            {
                Console.WriteLine($"{getal1} - {getal2} = {getal1-getal2}");
            }
            else
            {
                Console.WriteLine($"{getal2} - {getal1} = {getal2 - getal1}");
            }

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
    }
}
