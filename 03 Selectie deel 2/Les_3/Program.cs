using System;

namespace Les_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaratie variabelen
            string naam, geslacht, aanspreektitel;
            int leeftijd;

            // scherminstellingen wijzigen
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Les 03";

            // data inlezen
            Console.Write("Geef uw naam: ");
            naam = Console.ReadLine();
            Console.Write($"{naam.ToUpper()}, wat is uw leeftijd? ");
            leeftijd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{naam}, bent u een man of een vrouw? (m/v)");
            geslacht = Console.ReadLine();

            if (leeftijd < 25)
            {
                if (geslacht.ToLower() == "m")
                {
                    aanspreektitel = "jongeheer";
                }
                else
                {
                    aanspreektitel = "juffrouw";
                }
            }
            else
            {
                if (geslacht.ToLower() == "m")
                {
                    aanspreektitel = "meneer";
                }
                else
                {
                    aanspreektitel = "mevrouw";
                }
            }

            // resultaat tonen
            Console.WriteLine($"\nDag {aanspreektitel} {naam}");

            // afsluiten met enter
            Console.WriteLine("\nDruk op ENTER om naar het volgende voorbeeld te gaan!");
            Console.ReadLine();
            Console.Clear ();

            // declaratie variabelen
            string letter, uitvoer;

            // data opvragen
            Console.Write("Geef een letter: ");
            letter = Console.ReadLine();

            // bewerkingen uitvoeren
            switch (letter.ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u": 
                    uitvoer = "klinker";
                    break;
                default:
                    uitvoer = "medeklinker"; 
                    break;
            }

            // resultaat tonen
            Console.WriteLine($"\n{letter} is een {uitvoer}.");

            // afsluiten met enter
            Console.WriteLine("\nDruk op ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
