using System;

namespace oef_04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen
            Console.Title = "Oefening 4.04";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // data opvragen
            string symbEen = GeefSymbool();
            string symbTwee = GeefSymbool();
            int lengte = GeefMaat("lengte");
            int breedte = GeefMaat("breedte");

            // bewerkingen uitvoeren
            bool isEen = true;
            string output = string.Empty;

            for (int i = 0; i < lengte; i++)
            {
                if (isEen)
                {
                    PrintLijn(breedte, output, symbEen);
                    isEen = false;
                }
                else
                {
                    PrintLijn(breedte,output, symbTwee);
                    isEen = true;
                }
            }

            Console.WriteLine(output);

            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string GeefSymbool()
        {
            Console.Write("Geef een symbool: ");
            return Console.ReadLine();
        }
        private static int GeefMaat(string zijde)
        {
            Console.Write($"Geef een {zijde}: ");
            return int.Parse(Console.ReadLine());
        }
        private static string PrintLijn(int maat, string output, string symbool)
        {
            for (int i = 0; i < maat; i++)
            {
                output += symbool + " ";
            }
            output += "\n";
            return output;
        }
    }
}
