using System;

namespace oef_06_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string klant,
                 invoer;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "06 dowhile - oplossing 07";

            Console.Write("Naam klant: ");
            klant = Console.ReadLine();

            while (klant != "")
            {
                int totaal = 0;

                Console.Write("Donut of koffie? ");
                invoer = Console.ReadLine();

                while (invoer != "")
                {
                    if (invoer.ToLower() == "koffie")
                    {
                        totaal += 3;
                    }
                    else if (invoer.ToLower() == "donut")
                    {
                        totaal += 2;
                    }

                    Console.Write("Donut of koffie? ");
                    invoer = Console.ReadLine();
                }
                string rekeningTitel = $"Rekening {klant}";
                Console.WriteLine(
                    $"{rekeningTitel}\n{new string('*', rekeningTitel.Length)}\nTotaal: {totaal} euro"
                );

                Console.Write("Naam klant: ");
                klant = Console.ReadLine();
            }

            
            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
