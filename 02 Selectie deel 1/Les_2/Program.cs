using System;

namespace Les_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherminstellingen
            Console.Title = "Les 2";
            Console.BackgroundColor= ConsoleColor.Gray;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Voorbeeld 1");
            Console.WriteLine("___________");
            Console.WriteLine("");

            // variabelen declareren
            string activiteit, tijdstip, antwoord;
            bool benJeVrij;

            // gegevens opvragen
            Console.WriteLine("Ontvangen sms-bericht:");
            Console.Write("Voor welke activiteit kreeg je een sms bericht? ");
            activiteit = Console.ReadLine();

            Console.Write($"Wanneer gaat \"{activiteit}\" door? ");
            tijdstip = Console.ReadLine();

            Console.Write($"Ben je vrij op {tijdstip} (\"true\" of \"false\")? ");
            benJeVrij = bool.Parse(Console.ReadLine());

            // gegevens controleren
            if (benJeVrij == true)
            {
                antwoord = "Ik zal er zijn!";
            }
            else
            {
                antwoord = "Spijtig, ik kan niet!";
            }

            // resultaat afdrukken
            Console.WriteLine($"{antwoord}");

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
