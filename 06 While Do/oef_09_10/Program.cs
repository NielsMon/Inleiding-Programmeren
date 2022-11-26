using System;

namespace oef_09_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 10";

            // Declaratie variabelen
            string naam = string.Empty, aantalLiter = string.Empty, geslacht = string.Empty, 
                kado = string.Empty, output = string.Empty;
            bool stop = false;

            // Bewerkingen uitvoeren
            naam = vraagNaam();
            
            while (!stop)
            {
                if (string.IsNullOrWhiteSpace(naam))
                {
                    stop = true;
                }

                if (!stop)
                {
                    aantalLiter = vraagLiter();
                    if (string.IsNullOrWhiteSpace(aantalLiter))
                    {
                        stop = true;
                    }
                }

                if (!stop)
                {
                    geslacht = vraagGeslacht();
                    if (string.IsNullOrWhiteSpace(geslacht))
                    {
                        stop = true;
                    }
                }

                if (geslacht == "man" && !string.IsNullOrWhiteSpace(geslacht) &&int.Parse(aantalLiter) > 25)
                {
                    kado = "een sleutelhanger";
                }
                else if (geslacht == "vrouw" && !string.IsNullOrWhiteSpace(geslacht) && int.Parse(aantalLiter) > 25)
                {
                    kado = "een bloem";
                }
                else
                {
                    kado = "geen kado";
                }

                if (!stop)
                {

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        output = $"{naam} krijgt {kado} en moet {int.Parse(aantalLiter) * 2} euro betalen!";
                    }
                    else
                    {
                        output += $"\n{naam} krijgt {kado} en moet {int.Parse(aantalLiter) * 2} euro betalen!";
                    }
                    
                    naam = vraagNaam();
                }
            }

            Console.WriteLine(output);
            
            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadKey();
        }

        public static string vraagNaam()
        {
            Console.Write("Naam: ");
            string naam = Console.ReadLine();

            return naam;
        }

        public static string vraagLiter()
        {
            string input, output = string.Empty;
            int liter;
            bool succes = false;
            do
            {
                Console.Write("Aantal liters: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out liter);
                if (succes)
                {
                    output = input;
                }
                if (string.IsNullOrWhiteSpace(input))
                {
                    succes = true;
                    output = string.Empty;
                }
            } while (!succes);

            return output;
        }

        public static string vraagGeslacht()
        {
            string geslacht;
            bool succes = false;
            do
            {
                Console.Write("Geslacht (man/vrouw): ");
                geslacht = Console.ReadLine();
                if (geslacht.ToLower() == "vrouw" || geslacht.ToLower() == "man" || string.IsNullOrWhiteSpace(geslacht))
                {
                    succes = true;
                }
            } while (!succes);

            return geslacht;
        }
    }
}
