using System;

namespace oef_02_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// scherm instellingen
            //Console.Title = "Oefening 02.08";
            //Console.BackgroundColor = ConsoleColor.Gray;
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Clear();

            //// variabelen declareren
            //double bedrag, resultaat;
            //string koers;

            //// waarden inlezen
            //Console.Write("Geef een bedrag (EUR): ");
            //bedrag = double.Parse(Console.ReadLine());
            //Console.Write("Geef een willekoers (USD/GBP): ");
            //koers = Console.ReadLine();

            //// selectie controleren
            //if (koers == "USD")
            //{
            //    resultaat = bedrag * 0.77;
            //}
            //else
            //{
            //    resultaat = bedrag * 1.08;
            //}

            //// resultaat afdrukken
            //Console.WriteLine($"{koers}: {resultaat}");

            //// programma afsluiten
            //Console.WriteLine("\nDruk ENTER om af te sluiten!");
            //Console.ReadLine();

            Console.Title = "02 Selectie - oplossing 08";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            string wisselKoers;
            double bedragInEuro;

            // Inlezen
            bedragInEuro = double.Parse(Console.ReadLine());
            wisselKoers = Console.ReadLine();

            if (wisselKoers == "USD")
            {
                Console.WriteLine($"USD: {bedragInEuro * 0.77:N2}");
            }
            else if (wisselKoers == "GBP")
            {
                Console.WriteLine($"GBP: {bedragInEuro * 1.08:N2}");
            }
            else
            {
                Console.WriteLine($"Foutieve wisselkoers");
            }

            Console.ReadLine();
        }
    }
}
