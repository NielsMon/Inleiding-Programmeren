using System;

namespace oef_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Les 6: Oefening 3";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Variabelen declareren
            string ploeg, symbEen, symbTwee;
            string output = string.Empty;
            int lengte, breedte;

            // Data opvragen
            do
            {
                Console.Write("Geef een ploeg: ");
                ploeg = Console.ReadLine();
            } while (ploeg.Length <= 5 && ploeg != "*****");

            while (ploeg != "*****")
            {
                output += ploeg + "\n";

                Console.Write("Geef een symbool: ");
                symbEen = Console.ReadLine();
                Console.Write("Geef een symbool: ");
                symbTwee = Console.ReadLine();

                do
                {
                    Console.Write("Geef een lengte: ");
                    lengte = int.Parse(Console.ReadLine());
                } while (lengte < 4);

                do
                {
                    Console.Write("Geef een breedte: ");
                    breedte = int.Parse(Console.ReadLine());
                } while (breedte <= lengte / 2);


                // bewerkingen uitvoeren
                bool isEen = true;
                for (int i = 0; i < lengte; i++)
                {
                    if (isEen)
                    {
                        for (int j = 0; j < breedte; j++)
                        {
                            output += symbEen;
                        }
                        isEen = false;
                        output += "\n";
                    }
                    else
                    {
                        for (int j = 0; j < breedte; j++)
                        {
                            output += symbTwee;
                        }
                        isEen = true;
                        output += "\n";
                    }
                }
                do
                {
                    Console.Write("Geef een ploeg: ");
                    ploeg = Console.ReadLine();
                } while (ploeg.Length <= 5 && ploeg != "*****");
            }

            // Resultaat afdrukken
            Console.Clear();
            Console.WriteLine(output);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
