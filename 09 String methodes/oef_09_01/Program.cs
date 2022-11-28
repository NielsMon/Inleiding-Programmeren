using System;

namespace oef_09_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            int som = MaakSom(LeesGetal());
            Console.WriteLine($"De som is: {som}");

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: STRING METHODES";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string LeesGetal()
        {
            string input;
            int getal;
            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return input;
        }
        private static int MaakSom(string input)
        {
            int som = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int getal = int.Parse(input.Substring(i, 1));
                som += getal;
            }
            return som;
        }
    }
}
