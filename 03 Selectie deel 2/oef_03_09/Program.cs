using System;

namespace oef_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een maand: ");
            string maand = Console.ReadLine();

            switch (maand)
            {
                case "januari":
                case "maart":
                case "mei":
                case "juli":
                case "augustus":
                case "oktober":
                case "december": Console.WriteLine("31 dagen.");break;
                case "april":
                case "juni":
                case "september":
                case "november": Console.WriteLine("30 dagen.");break;
                case "februari": Console.WriteLine("28/29 dagen.");break;
                default:
                    Console.WriteLine("Foutieve invoer.");
                    break;
            }
        }
    }
}
