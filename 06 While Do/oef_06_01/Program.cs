using System;

namespace oef_06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 1";

            // Variabelen declareren
            string naamEvent;
            string antwoord;
            string naam;
            string output = string.Empty;
            bool stop = false;

            // Gegevens inlezen
            naamEvent = leesEvent();

            while (!stop)
            {
                Console.Write("Wilt u een naam toevoegen (ja/nee)? ");
                antwoord = Console.ReadLine();

                if (antwoord == "ja")
                {
                    Console.Write("naam: ");
                    naam = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(output))
                    {
                        output = naam;
                    }
                    else
                    {
                        output += "\n" + naam;
                    }
                    
                }else if (antwoord == "nee")
                {
                    stop = true;
                }
            }

            // Resultaat afdrukken
            if (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine($"Er zijn geen aanwezigen voor {naamEvent}!");
            }
            else
            {
                Console.WriteLine($"Aanwezigen voor {naamEvent}:");
                Console.WriteLine(output);
            }
            
        }
        public static string leesEvent()
        {
            string naam;

            do
            {
                Console.Write("Naam event: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            return naam;
        }
    }
}
