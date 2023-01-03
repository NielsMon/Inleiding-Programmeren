using System;

namespace oef_08_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int getal = LeesGetal("Geef een getal: ");
            int som = 0, counter = 0, min = int.MaxValue, max = int.MinValue;

            while (getal != 0)
            {
                som += getal;
                counter++;
                min = getal < min? getal : min;
                max = getal > max? getal : max;
                getal = LeesGetal("Geef een getal: ");
            }
            Console.Clear();
            Console.WriteLine($"Statistieken:\n" +
                $"Hoogste cijfer: {max}\n" +
                $"Laagste cijfer: {min}\n" +
                $"Gemiddelde: {som/counter}");
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 8: Oefening 8";
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
    }
}
