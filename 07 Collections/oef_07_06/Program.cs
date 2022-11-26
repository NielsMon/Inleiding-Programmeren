using System;

namespace oef_07_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 6";

            // Variabelen declareren
            int[] plaatsen = new int[40];
            bool succes = false, stop = false;
            string input = string.Empty;
            int getal;

            // Data inlezen
            do
            {
                Console.Write("Reserveer plaats: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
                if (input == "stop")
                {
                    succes = true;
                    stop = true;
                }
            } while (!succes);

            while (!stop)
            {
                if (getal < 1 || getal > 40)
                {
                    Console.WriteLine("Deze zitplaats bestaat niet");
                }else if (plaatsen[getal -1] == getal)
                {
                    Console.WriteLine("Deze zitplaats is bezet");
                }
                else
                {
                    plaatsen[getal -1] = getal;
                }

                do
                {
                    Console.Write("Reserveer plaats: ");
                    input = Console.ReadLine();
                    succes = int.TryParse(input, out getal);
                    if (input == "stop")
                    {
                        succes = true;
                        stop = true;
                    }
                } while (!succes);
            }

            // Resultaten afdrukken
            foreach (var item in plaatsen)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
                
            }


            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
