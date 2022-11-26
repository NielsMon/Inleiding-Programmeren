using System;

namespace oef_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Geef uw naam: ");
            string naam = Console.ReadLine();

            Console.WriteLine("Geef aan de hand van het cijfer 1 tem 7 uw hobby:");
            Console.WriteLine("\t1 - Handwerk");
            Console.WriteLine("\t2 - Kleding maken");
            Console.WriteLine("\t3 - Interieur");
            Console.WriteLine("\t4 - Voetballen");
            Console.WriteLine("\t5 - Fietsen");
            Console.WriteLine("\t6 - Fotografie");
            Console.WriteLine("\t7 - Lopen");
            int hobbyInput = int.Parse(Console.ReadLine());

            string tijdschrift;
            switch (hobbyInput)
            {
                case 1: tijdschrift = "\"Anna\""; break;
                case 2: tijdschrift = "\"Knippie\""; break;
                case 3: tijdschrift = "\"VtWonen\""; break;
                case 4: tijdschrift = "\"Voetbal International\""; break;
                case 5: tijdschrift = "\"Wandelen & fietsen\""; break;
                case 6: tijdschrift = "\"Zoom NL\""; break;
                case 7: tijdschrift = "\"Runners\""; break;
                default:tijdschrift = "-"; break;
            }

            Console.WriteLine($"{voornaam.ToLower()} {naam.ToUpper()}, tijdschrift: {tijdschrift}");
        }
    }
}
