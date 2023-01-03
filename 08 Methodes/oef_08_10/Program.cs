using System;

namespace oef_08_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            int x = LeesGetal("Geef een getal: ");
            int n = LeesGetal("Geef een getal: ");
            int[] veelvouden = CreeerVeelvouden(x,n);
            BerekenMiddelste(veelvouden);
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 8: Oefening 10";
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
        private static int[] CreeerVeelvouden(int x, int n)
        {
            int[] veelvouden = new int[n];
            for (int i = 0; i < n; i++)
            {
                veelvouden[i] = (x * (i+1));
            }
            return veelvouden;
        }
        private static void BerekenMiddelste(int[] veelvouden)
        {
            string output;
            int middelste = veelvouden.Length / 2;
            output = veelvouden.Length%2 == 0 ? $"{veelvouden[middelste-1]} - {veelvouden[middelste]}" :
                $"{veelvouden[middelste]}";
            Console.WriteLine(output);
        }
    }
}
