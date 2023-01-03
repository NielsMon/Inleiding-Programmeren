using System;

namespace oef_08_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int getal1 = LeesGetal("Geef een getal: ");
            int getal2 = LeesGetal("Geef een getal: ");
            DrukSom(getal1, getal2);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 8: Oefening 9";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om programma te eindigen!");
            Console.ReadLine();
        }
        private static int LeesGetal(string message)
        {
            string input;
            int getal;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }
        private static void DrukSom(int getal1, int getal2)
        {
            int som = 0;
            for (int i = getal1; i <= getal2; i++)
            {
                if (i%10 == 0)
                {
                    som += i;
                }
            }
            Console.WriteLine($"Som: {som}");
        }
    }
}
