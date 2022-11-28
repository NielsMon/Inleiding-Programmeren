using System;

namespace oef_09_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            ControleerPalindroom(LeesWoord().ToLower());

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: Oefening 3";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string LeesWoord()
        {
            Console.Write("Woord: ");
            return Console.ReadLine();
        }
        private static void ControleerPalindroom(string woord)
        {
            string first = woord.Substring(0, (woord.Length - 1) / 2);
            string second = woord.Substring((woord.Length + 1) / 2, (woord.Length - 1) / 2);

            string controle = string.Empty;
            for (int i = second.Length-1; i >= 0; i--)
            {
                controle += second[i];
            }

            string antwoord;
            if (controle.Equals(first))
            {
                antwoord = "een";
            }
            else
            {
                antwoord = "geen";
            }

            Console.WriteLine($"{woord} is {antwoord} palindroom");
        }
    }
}
