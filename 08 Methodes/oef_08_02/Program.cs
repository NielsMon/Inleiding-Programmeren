using System;

namespace oef_08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            
            // Lees twee symbolen in
            string symbol1 = ReadSymbol(String.Empty);
            string symbol2 = ReadSymbol(symbol1);

            // vraag lengte en breedte
            int lengte = ReadNumber();
            int breedte = ReadNumber();

            // lijnen aanmaken
            string line1 = MakeLine(symbol1, breedte);
            string line2 = MakeLine(symbol2, breedte);

            // sjaal printen
            Console.Clear();
            Console.WriteLine(CreateScarf(line1, line2, lengte));
            EindeProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 8: Oefening 2";
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk Enter om af te sluiten!");
            Console.ReadLine();
        }
        private static int ReadNumber()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return number;
        }
        private static string ReadSymbol(string compareSymbol)
        {
            string input;
            do
            {
                Console.Write("Geef een symbool: ");
                input = Console.ReadLine();
            } while (input.Length > 1 || input == compareSymbol);
            return input;
        }
        private static string MakeLine(string symbol, int length)
        {
           string output = new String(char.Parse(symbol), length);
           return output;
        }
        private static string CreateScarf(string line1, string line2, int length)
        {

            string output = line1;
            bool lineOneDone = false;
            for (int i = 1; i < length; i++)
            {
                if (lineOneDone)
                {
                    output += "\n" + line1;
                    lineOneDone = false;
                }else
                {
                    output += "\n" + line2;
                    lineOneDone = true;
                }
            }
            return output;
        }
    }
}
