using System;

namespace oef_02_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // scherm instellingen
            Console.Title = "Oefening 02.08";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // variabelen declareren
            double btw, bedrag, totaal;
            string btwperc;

            // waarden inlezen
            Console.Write("Geef een btw tarief (1/2/3/4): ");
            btw = double.Parse(Console.ReadLine());
            Console.Write("Geef een bedrag: ");
            bedrag = double.Parse(Console.ReadLine());

            // selectie controleren
            if (btw == 1)
            {
                totaal = bedrag;
                btwperc = "0";
            }else if (btw == 2)
            {
                totaal = bedrag + (bedrag * 0.06);
                btwperc = "6";
            }
            else if (btw == 3)
            {
                totaal = bedrag + (bedrag * 0.12);
                btwperc = "12";
            }
            else
            {
                totaal = bedrag + (bedrag * 0.21);
                btwperc = "21";
            }

            // resultaat afdrukken
            Console.WriteLine($"{btwperc}, totaal: {totaal}");

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
