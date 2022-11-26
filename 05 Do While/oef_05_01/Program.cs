using System;

namespace oef_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 05: Oefening 1";

            Console.WriteLine("Les 5: Oefening 1");
            Console.WriteLine(new String('_', Console.Title.Length));


            // Data inlezen
            string input = string.Empty;
            bool succes = false;
            int getalEen;
            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getalEen);
            } while (!succes);

            int getalTwee;
            do
            {
                Console.Write("Geef een tweede getal: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getalTwee);
            } while (!succes);

            // Controle gegevens en resultaat afdrukken
            if (getalEen < getalTwee)
            {
                Console.WriteLine($"{getalTwee} - {getalEen} = {getalTwee - getalEen}");
            }
            else
            {
                Console.WriteLine($"{getalEen} - {getalTwee} = {getalEen - getalTwee}");
            }

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
