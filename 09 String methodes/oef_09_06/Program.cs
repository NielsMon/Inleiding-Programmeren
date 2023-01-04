using System;

namespace oef_09_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            string woordEen = ReadWord("Geef een woord: ");
            string woordTwee = ReadWord("Geef een woord: ");
            UnderlineWords(woordEen, woordTwee);

            EndProgram();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 9: Oefening 6";
        }
        private static void EndProgram()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string ReadWord(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        private static void UnderlineWords(string woordEen, string woordTwee)
        {
            int min = Math.Min(woordEen.Length, woordTwee.Length);
            string output = "";
            for (int i = 0; i < min; i++)
            {
                output += woordEen.Substring(i, 1) == woordTwee.Substring(i, 1) ? "-" : " ";
            }
            Console.WriteLine(output);
        }
    }
}
