using System;

namespace oef_03_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een letter: ");
            string letter = Console.ReadLine();

            string uitvoer;
            switch (letter.ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    uitvoer = "Klinker.";
                    break;
                default:
                    uitvoer = "Medeklinker.";
                    break;
            }

            Console.WriteLine(uitvoer);
        }
    }
}
