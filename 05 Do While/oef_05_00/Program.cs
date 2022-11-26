using System;

namespace oef_05_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 05: Oefening 00";

            Console.WriteLine("Les 5: Oefening 00");
            Console.WriteLine("__________________");


            // Data inlezen
            string input;
            double waarde;
            do
            {
                Console.Write("Geef de waarde opgenomen koffie in mg: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out waarde));
            
            // Bewerkingen uitvoeren
            int counter = 0;

            do
            {
                counter += 5;
                waarde = waarde/2;
            } while (waarde > 1);

            // Resultaat afdrukken
            Console.WriteLine($"Totale tijd: {counter} uur");

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
