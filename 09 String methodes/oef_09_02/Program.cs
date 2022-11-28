using System;

namespace oef_09_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            string input = GeefRekeningnummer();

            Console.WriteLine(input.Length == 14);
            Console.WriteLine(input.IndexOf("-") == 3);
            Console.WriteLine(input.LastIndexOf("-") == 11);
            Console.WriteLine(IsNumber(input.Substring(0, 3)));
            Console.WriteLine(IsNumber(input.Substring(4, 7)));
            Console.WriteLine(IsNumber(input.Substring(12, 2)));
            Console.WriteLine(long.Parse(input.Substring(0, 3) + input.Substring(4, 7)));
            Console.WriteLine(long.Parse(input.Substring(12, 2)));
            Console.WriteLine(long.Parse(input.Substring(0, 3) + input.Substring(4, 7)) % long.Parse(input.Substring(12, 2)));
            Console.WriteLine(long.Parse(input.Substring(0, 3) + input.Substring(4, 7)) % long.Parse(input.Substring(12, 2)) == long.Parse(input.Substring(12, 2)));

            IsRekeningNummer(input);
            

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: Oefening 2";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string GeefRekeningnummer()
        {
            Console.Write("Rekeningnummer: ");
            string input = Console.ReadLine();
            return input;
        }
        private static bool IsNumber(string input)
        {
            int getal;
            return int.TryParse(input, out getal);
        }
        private static void IsRekeningNummer(string input)
        {
            string result = "niet geldig";
            if (input.Length == 14 && input.IndexOf("-") == 3 && input.LastIndexOf("-") == 11)
            {
                if (IsNumber(input.Substring(0, 3)) && IsNumber(input.Substring(4, 7)) && IsNumber(input.Substring(12, 2)))
                {
                    long noemer = long.Parse(input.Substring(0, 3) + input.Substring(4, 7));
                    long deler = long.Parse(input.Substring(12, 2));
                    if (noemer%deler == deler)
                    {
                        result = "geldig";
                    }
                }
            }

            Console.WriteLine($"De bankkaart is {result}");
        }
    }
}
