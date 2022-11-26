using System;

namespace oef_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.Title = "Oefening 02.03";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            string voornaam, familienaam;
            int leeftijd;

            // waarden inlezen
            Console.Write("Geef je voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef je familienaam: ");
            familienaam = Console.ReadLine();
            Console.Write("Geef je leeftijd: ");
            leeftijd = int.Parse(Console.ReadLine());

            if (leeftijd < 18)
            {
                Console.WriteLine($"{voornaam} {familienaam}: Jeugd");
            }
            else
            {
                Console.WriteLine($"{voornaam} {familienaam}: Volwassenen");
            }

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
