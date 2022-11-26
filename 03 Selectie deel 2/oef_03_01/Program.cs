using System;

namespace oef_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.Write("Geef een getal: ");
            int getal2 = int.Parse(Console.ReadLine());
            Console.Write("Geef een getal: ");
            int getal3 = int.Parse(Console.ReadLine());

            Console.Write("Geef een lettercode (A/B): ");
            string lettercode = Console.ReadLine();

            Console.Write("Geef een cijfercode (1/2/3): ");
            string cijfercode = Console.ReadLine();

            if (lettercode.ToUpper() == "A" && cijfercode == "1")
            {
                Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
            }
            else if (lettercode.ToUpper() == "A" && cijfercode == "2")
            {
                Console.WriteLine($"{getal2} + {getal3} = {getal2 + getal3}");
            }
            else if (lettercode.ToUpper() == "A" && cijfercode == "3")
            {
                Console.WriteLine($"{getal1} + {getal3} = {getal1 + getal3}");
            }
            else if (lettercode.ToUpper() == "B" && cijfercode == "1")
            {
                Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
            }
            else if (lettercode.ToUpper() == "B" && cijfercode == "2")
            {
                Console.WriteLine($"{getal2} - {getal3} = {getal2 - getal3}");
            }
            else if (lettercode.ToUpper() == "B" && cijfercode == "3")
            {
                Console.WriteLine($"{getal1} - {getal3} = {getal1 - getal3}");
            }
        }
    }
}
