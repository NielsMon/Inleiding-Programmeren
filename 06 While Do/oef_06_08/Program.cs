using System;

namespace oef_06_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.Title = "Les 6: Oefening 8";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variablen declareren
            string figuur;
            bool succes = false;
            double breedte, hoogte, straal;

            // Bewerkingen uitvoeren
            do
            {
                Console.WriteLine("Van welke figuur wil je de oppervlakte berekenen?");
                Console.Write("Driehoek, rechthoek of een cirkel: ");
                figuur = Console.ReadLine().ToLower();
                if (figuur == "driehoek" || figuur == "rechthoek" || figuur == "cirkel" || string.IsNullOrWhiteSpace(figuur))
                {
                    succes = true;
                }
            } while (!succes);


            while (!string.IsNullOrWhiteSpace(figuur))
            {
                if (figuur == "driehoek")
                {
                    Console.Write("basis: ");
                    breedte = int.Parse(Console.ReadLine());
                    Console.Write("hoogte: ");
                    hoogte = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Oppervlakte: {(int)(breedte * hoogte) / 2}");
                }
                else if (figuur == "rechthoek")
                {
                    Console.Write("breedte: ");
                    breedte = int.Parse(Console.ReadLine());
                    Console.Write("hoogte: ");
                    hoogte = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Oppervlakte: {(int)(breedte * hoogte)}");
                }
                else if (figuur == "cirkel")
                {
                    Console.Write("straal: ");
                    straal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Oppervlakte: {(int)(Math.PI * straal * straal)}");
                }

                do
                {
                    Console.WriteLine("Van welke figuur wil je de oppervlakte berekenen?");
                    Console.Write("Driehoek, rechthoek of een cirkel: ");
                    figuur = Console.ReadLine().ToLower();
                    if (figuur == "driehoek" || figuur == "rechthoek" || figuur == "cirkel" || string.IsNullOrWhiteSpace(figuur))
                    {
                        succes = true;
                    }
                } while (!succes);

                // Programma beëindigen
                Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
