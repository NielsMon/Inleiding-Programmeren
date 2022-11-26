using System;

namespace oef_01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // console definiëren
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Title = "Oefening 01.07";

            // variabelen declareren
            string rood, blauw, temp;

            // waarden inlezen
            Console.WriteLine("Geef een eerste woord: ");
            rood = Console.ReadLine();
            Console.WriteLine("Geef een eerste woord: ");
            blauw = Console.ReadLine();

            // waarden afdrukken
            Console.WriteLine("Doos rood: {0}", rood);
            Console.WriteLine("Doos blauw: {0}", blauw);

            // waarden wisselen
            temp = rood;
            rood = blauw;
            blauw = temp;

            // waarden afdrukken
            Console.WriteLine("Doos rood na wissel: {0}", rood);
            Console.WriteLine("Doos blauw na wissel: {0}", blauw);

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
