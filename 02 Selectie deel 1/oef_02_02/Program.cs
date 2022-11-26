using System;

namespace oef_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherm instellingen
            Console.Title = "OEfening 02.02";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            int getal1, getal2;

            // getallen inlezen
            Console.Write("Geef een getal: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef een tweede getal: ");
            getal2 = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            if (getal2 == 0)
            {
                Console.WriteLine($"{getal1} is niet deelbaar door 0.");
            }
            else
            {
                Console.WriteLine($"{getal1} / {getal2} = {getal1/getal2}");
            }

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
