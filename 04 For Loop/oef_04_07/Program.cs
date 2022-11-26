using System;

namespace oef_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Oefening 4.07";

            // data opvragen
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());

            // bewerkingen uitvoeren
            int getalTwee = getal + 1;
            int tijdelijk;
            Console.WriteLine(getal);
            Console.WriteLine(getalTwee);

            for (int i = 0; i < 9; i++)
            {
                tijdelijk = getal;
                getalTwee += tijdelijk;
                getal = getalTwee;
                
                Console.WriteLine(getalTwee);
            }

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();


            int getal1 = 0, getal2 = 1, getal3, limiet;

            limiet = int.Parse(Console.ReadLine());

            Console.Write($"{getal1} {getal2} ");

            for (int i = 2; i < limiet; i++)
            {
                getal3 = getal1 + getal2;
                Console.Write($"{getal3} ");
                getal1 = getal2;
                getal2 = getal3;
            }
        }
    }
}
