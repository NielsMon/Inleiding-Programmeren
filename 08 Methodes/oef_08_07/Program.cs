using System;

namespace oef_08_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int getal = LeesGetal("Geef een getal: ");
            Deelbaar(getal, IsEven(getal));
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 8: Oefening 7";
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
        private static bool IsEven(int getal)
        {
            bool isEven = getal%2 == 0? true : false;
            return isEven;
        }
        private static void Deelbaar(int getal, bool isEven)
        {
            string output;
            if (isEven)
            {
                output = getal % 5 == 0 ? $"Even, deelbaar door 5." : $"Even, niet deelbaar door 5.";
            }
            else
            {
                output = getal % 7 == 0 ? $"Oneven, deelbaar door 7." : $"Oneven, niet deelbaar door 7.";
            }
            Console.WriteLine(output);
        }
    }
}
