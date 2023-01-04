using System;

namespace oef_09_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            string word = ReadWord("Geef een woord: ");
            InsertUnderscore(word);
            EndProgram();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 9: Oefening 10";
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
        private static void InsertUnderscore(string word)
        {
            string newWord = word;
            for (int i = 0; i < newWord.Length; i++)
            {
                Console.WriteLine(newWord.Substring(i, 1).PadLeft(i+1, '_'));
            }
        }
    }
}
