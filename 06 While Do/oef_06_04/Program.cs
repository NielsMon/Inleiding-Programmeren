using System;

namespace oef_06_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 6: Oefening 4";

            // Variabelen declareren
            bool stop = false;
            int getal;
            string output = string.Empty;

            // Gegevens ingeven
            getal = genereerGetal();

            // Data verwerken
            if (getal == 0)
            {
                stop = true;
            }

            while (!stop)
            {
                for (int i = 0; i < 10; i++)
                {
                    output += ($"{i+1} x {getal} = {(i+1)*getal}\n");
                }
                output += "\n";
                getal = genereerGetal();
                if (getal == 0)
                {
                    stop = true;
                }
            }

            // Resultaat afdrukken
            Console.Clear();
            Console.WriteLine(output);

            // Stop programma
            Console.WriteLine("Druk ENTER om het programma te stoppen!");
            Console.ReadLine();
        }
        public static int genereerGetal()
        {
            int getal;
            string input;
            do
            {
                Console.Write("Geef een positief getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }
    }
}
