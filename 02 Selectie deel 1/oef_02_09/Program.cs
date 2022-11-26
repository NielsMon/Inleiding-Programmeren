using System;

namespace oef_02_09
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
            double getal, dag, korting;

            // waarden inlezen
            Console.Write("Geef een getal: ");
            getal = double.Parse(Console.ReadLine());
            Console.Write("Geef een dag: ");
            dag = double.Parse(Console.ReadLine());

            // selectie controleren
            if (dag == 1 || dag == 3)
            {
                korting = 0.175;
            }else if (dag == 2)
            {
                korting = 0.125;
            }
            else if (dag%2 == 0)
            {
                korting = 0.1;
            }
            else
            {
                korting = 0.15;
            }

            // resultaat afdrukken
            Console.WriteLine($"Resultaat: {getal - (getal * korting)}");

            // programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
