using System;

namespace oef_03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal :");
            double getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef een getal :");
            double getal2 = int.Parse(Console.ReadLine());
            Console.Write("Geef een getal :");
            double getal3 = int.Parse(Console.ReadLine());

            Console.Write("Geef een code (a/b/c/d): ");
            string code = Console.ReadLine();

            double resultaat;
            switch (code.ToLower())
            {
                case "a":
                    Console.WriteLine($"Uitkomst: {getal1 + getal2 + getal3}");
                    break;
                case "b":
                    Console.WriteLine($"Uitkomst: {getal1 * getal3}");
                    break;
                case "c":
                    Console.WriteLine($"Uitkomst: {getal3 - getal2}");
                    break;
                case "d":
                    if (getal1 > 0)
                    {
                        Console.WriteLine($"Uitkomst: {Math.Sqrt(getal1)}");
                    }
                    else
                    {
                        Console.WriteLine("Foutieve invoer.");
                    }
                    break;
                default:
                    if (getal1 > getal2 && getal1 > getal3)
                    {
                        Console.WriteLine($"Uitkomst: {getal1}");
                    }
                    else if (getal2 > getal1 && getal2 > getal3)
                    {
                        Console.WriteLine($"Uitkomst: {getal2}");
                    }else
                    {
                        Console.WriteLine($"Uitkomst: {getal3}");
                    }
                    break;
            }
        }
    }
}
