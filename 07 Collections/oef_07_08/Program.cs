using System;

namespace oef_07_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int x = LeesGetal("Geef een veelvoud: ");
            int n = LeesGetal("Geef een aantal: ");
            int[] reeks = GeefGetallenReeks(x, n);
            BerekenMiddelsteGetal(reeks);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 7: Oefening 7";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om verder te gaan!");
            Console.ReadLine();
        }
        private static int LeesGetal(string vraag)
        {
            int getal;
            string input;
            do
            {
                Console.Write(vraag);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal));
            return getal;
        }
        private static int[] GeefGetallenReeks(int x, int n)
        {
            int[] reeks = new int[n];
            for (int i = 0; i < n; i++)
            {
                reeks[i] = x * (i+1);
            }
            return reeks;
        }
        private static void BerekenMiddelsteGetal(int[] reeks)
        {
            string output;
            int middelste = reeks.Length / 2;
            if (reeks.Length%2 == 0)
            {
                output = $"{reeks[middelste-1]} - {reeks[middelste]}";
            }
            else
            {
                output = $"{reeks[middelste]}";
            }
            Console.Clear();
            Console.WriteLine(output);
        }
    }
}
