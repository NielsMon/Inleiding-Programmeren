using System;

namespace Les_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 06: While DO";

            // Declaratie variabelen
            string titel = "Les 06: While DO";
            string input = string.Empty;
            string naam = string.Empty;
            string adres = string.Empty;
            int aantalEtiketten;
            bool succes;

            Console.WriteLine(titel);
            Console.WriteLine(new string('_', titel.Length));

            // Data inlezen
            do
            {
                Console.WriteLine("Hoeveel etiketten wenst u af te drukken (0=stop)?");
                input = Console.ReadLine();
                succes = int.TryParse(input, out aantalEtiketten);
            } while (!succes);

            while (aantalEtiketten != 0)
            {
                // Inlezen inputvelden
                Console.WriteLine("Geef de gewenste voor- en familienaam op: ");
                naam = Console.ReadLine();
                Console.WriteLine("Geef het adres op van {0}: ", naam.ToUpper());
                adres = Console.ReadLine();
                Console.Clear();

                // Afdrukken gevraagde adresetiketten
                for (int i = 0; i < aantalEtiketten; i++)
                {
                    Console.WriteLine(new string('-', adres.Length));
                    Console.WriteLine(naam);
                    Console.WriteLine(adres);
                    Console.WriteLine(new string('-', adres.Length));
                    Console.WriteLine();
                }

                // Data inlezen
                do
                {
                    Console.WriteLine("Hoeveel etiketten wenst u af te drukken (0=stop)?");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out aantalEtiketten);
                } while (!succes);
            }
            
            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
