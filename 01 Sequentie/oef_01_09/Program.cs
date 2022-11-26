using System;

namespace oef_01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // console declareren
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Oefening 01.09";

            // variabelen declareren
            int getal;

            // inlezen waarden
            Console.WriteLine("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());

            // waarden afdrukken
            Console.WriteLine(Math.Pow(getal -1, 2));
            Console.WriteLine(Math.Pow(getal, 2));
            Console.WriteLine(Math.Pow(getal +1, 2));

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
