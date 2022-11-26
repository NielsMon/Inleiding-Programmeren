using System;

namespace oef_06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 2";

            // Variabelen declareren
            string voornaam = string.Empty;
            string familienaam = string.Empty;
            bool stop = false;
            string tijdschrift;
            string output = string.Empty;
            int hobby;

            // Gegevens inlezen
            do
            {
                Console.Write("Voornaam: ");
                voornaam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(voornaam));

            do
            {
                Console.Write("Familienaam: ");
                familienaam= Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(familienaam));

            Console.WriteLine("Hobby: ");
            Console.WriteLine("\t1 - Handwerk");
            Console.WriteLine("\t2 - Kleding maken");
            Console.WriteLine("\t3 - Interieur");
            Console.WriteLine("\t4 - Voetballen");
            Console.WriteLine("\t5 - Fietsen");
            Console.WriteLine("\t6 - Fotografie");
            Console.WriteLine("\t7 - Lopen");
            Console.WriteLine("\t8 - ...");

            hobby = vraagHobby();
            if (hobby == 8)
            {
                stop = true;
                if (string.IsNullOrEmpty(output))
                {
                    output = "Wij raden niets aan.";
                }
            }

            while (!stop)
            {
                switch (hobby)
                {
                    case 1: tijdschrift = "Anna"; break;
                    case 2: tijdschrift = "Knippie"; break;
                    case 3: tijdschrift = "VtWonen"; break;
                    case 4: tijdschrift = "Voetbal international"; break;
                    case 5: tijdschrift = "Wandelen & fietsen"; break;
                    case 6: tijdschrift = "Zoom NL"; break;
                    case 7: tijdschrift = "Runners"; break;
                    default: tijdschrift = "niets"; break;
                }

                if (string.IsNullOrWhiteSpace(output))
                {
                    output = $"Wij raden \"{tijdschrift}\" aan.";
                }
                else
                {
                    output += $"\nWij raden \"{tijdschrift}\" aan.";
                }

                hobby = vraagHobby();
                if (hobby == 8)
                {
                    stop = true;
                }
            }

            // Resultaat afdrukken
            Console.Clear();
            Console.WriteLine(output);

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om het programma te beëindigen!");
            Console.ReadLine();
        }

        public static int vraagHobby()
        {
            string input;
            int hobby;
            bool succes;
            do
            {
                Console.Write("Geef een hobby: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out hobby);
                if (hobby < 1 && hobby > 8)
                {
                    succes = false;
                }
            } while (!succes);

            return hobby;
        }
    }
}
