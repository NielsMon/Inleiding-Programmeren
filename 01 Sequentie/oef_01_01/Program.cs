using System;

namespace oef_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // schermkleuren aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear(); // update kleuren gebeurd pas na Console.Clear()
            Console.Title = "Oefening 01.01";

            // variabelen declareren
            int getal1, getal2, getal3, getal4;
            int optelling, vermenigvuldiging;

            // getallen inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            // berekeningen maken
            optelling = getal1 + getal3;
            vermenigvuldiging = getal2 * getal4;

            // resultaat afdrukken
            Console.WriteLine($"Optelling: {optelling}");
            Console.WriteLine($"Vermenigvuldiging: {vermenigvuldiging}");

            // wachten op enter
            Console.WriteLine();
            Console.WriteLine("Druk op enter om verder te gaan!");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
