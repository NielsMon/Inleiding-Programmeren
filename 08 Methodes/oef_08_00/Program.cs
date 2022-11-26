using System;

namespace oef_08_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0, number;
            number = ReadNumber();
            while (!IsNegative(number))
            {
                totaal += number;
                number = ReadNumber();
            }
            DrukTotaal(totaal);
            StopProgramma();
        }
        private static bool IsNegative(int number)
        {
            bool result = false;
            if (number <= 0)
            {
                return true;
            }
            return result;
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
        private static void DrukTotaal(int totaal)
        {
            Console.WriteLine($"Totaal: {totaal.ToString()}");
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
