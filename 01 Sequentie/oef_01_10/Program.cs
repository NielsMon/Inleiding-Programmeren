using System;

namespace oef_01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // console declareren
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Oefening 01.10";

            // variabelen declareren
            double bedrag;

            // bedrag inlezen
            Console.WriteLine("Geef een bedrag: ");
            bedrag = double.Parse(Console.ReadLine());

            // resultaat adrukken
            Console.WriteLine("EUR: {0}", bedrag);
            Console.WriteLine("GBP: {0}", bedrag * 1.08);
            Console.WriteLine("USD: {0}", bedrag * 0.77);

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten");
            Console.ReadLine();
            */

            Console.Title = "01 Sequentie - oplossing 10";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Declaratie
            double bedragInEuro, bedragInUsd, bedragInGbp;

            // Inlezen
            bedragInEuro = double.Parse(Console.ReadLine());

            // Berekenen
            bedragInGbp = bedragInEuro * 1.08;
            bedragInUsd = bedragInEuro * 0.77;

            // Afdrukken
            Console.WriteLine($"EUR: {bedragInEuro:N2}");
            Console.WriteLine($"GBP: {bedragInGbp:N2}");
            Console.WriteLine($"USD: {bedragInUsd:N2}");

            Console.ReadLine();
        }
    }
}
