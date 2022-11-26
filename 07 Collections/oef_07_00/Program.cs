using System;
using System.Collections.Generic;

namespace oef_07_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 07: Oefening 1";

            // Variabelen declareren
            List<string> namen = new List<string>();
            namen.Add("Namen:");
            bool stop = false, succes;
            string input;

            // Data opvragen
            do
            {
                succes = false;
                do
                {
                    Console.Write("Wil je nog een naam toevoegen (ja/nee)? ");
                    input = Console.ReadLine();

                    if (input == "ja" || input == "nee")
                    {
                        succes = true;
                    }
                } while (!succes);

                if (input == "ja")
                {
                    namen.Add(Console.ReadLine());
                }
                else
                {
                    stop = true;
                }
            } while (!stop);

            // Resultaat afdrukken
            Console.Clear ();
            if (namen.Count > 1)
            {
                foreach (var item in namen)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Er zijn geen aanwezigen!");
            }
            
            // Programma afsluiten
            Console.WriteLine("\nDruk op ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}