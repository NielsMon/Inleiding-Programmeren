using System;

namespace oef_08_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int tafel = LeesGetal("Geef een tafel: ");
            OefenTafel(tafel);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 8: Oefening 6";
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
        private static void OefenTafel(int tafel)
        {
            int counter = 0;
            int resultaat;
            for (int i = 0; i < 10; i++)
            {
                resultaat = LeesGetal($"{tafel} * {i + 1} = ");
                if (resultaat == (tafel * (i+1)))
                {
                    counter++;
                }
            }
            Console.WriteLine($"U heeft {counter}/10 behaald!");
        }
    }
}
