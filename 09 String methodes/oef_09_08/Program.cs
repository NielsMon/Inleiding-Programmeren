using System;

namespace oef_09_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            string word = ReadWord("Geef een woord: ");
            InsertSign(word);
            EndProgram();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Les 9: Oefening 8";
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
        private static void InsertSign(string word)
        {
            string newWord = word;
            for (int i = 0; i < newWord.Length-1; i+=2)
            {
                newWord = newWord.Insert(i+1, "-");
            }
            
            Console.WriteLine(newWord);
        }
    }
}
