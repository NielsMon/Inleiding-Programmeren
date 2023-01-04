using System;

namespace oef_09_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            string word = ReadWord("Geef een woord: ");
            RemoveVowel(word);
            EndProgram();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 9: Oefening 7";
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
        private static void RemoveVowel(string word)
        {
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };

            for (int i = 0; i < word.Length; i++)
            {
                word = word.Replace(vowels[i], "");
            }
            Console.WriteLine(word);
        }
    }
}
