using System;

namespace oef_09_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            Console.WriteLine(TelAantalKlinkers(LeesZin()));

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: STRING METHODES";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string LeesZin()
        {
            Console.Write("Geef een zin: ");
            string zin = Console.ReadLine();

            return zin;
        }
        private static int TelAantalKlinkers(string zin)
        {
            zin = zin.ToLower();
            int som = 0;
            for (int i = 0; i < zin.Length; i++)
            {
                string letter = zin.Substring(i, 1);
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    som++;
                }
            }
            return som;
        }
    }
}
