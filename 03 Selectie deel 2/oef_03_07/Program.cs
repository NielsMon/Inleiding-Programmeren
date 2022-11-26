using System;

namespace oef_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de leeftijd van van uw kind: ");
            int leeftijd = int.Parse(Console.ReadLine());
            Console.Write("Geef de geboortemaand (1 = januari): ");
            int maandGeboren = int.Parse(Console.ReadLine());

            if (leeftijd <= 1)
            {
                Console.WriteLine("Peuterklas");
            }
            else if (leeftijd == 2)
            {
                if (maandGeboren <= 7)
                {
                    Console.WriteLine("Peuterklas");
                }
                else
                {
                    Console.WriteLine("Eerste kleuterklas");
                }
            }
            else if (leeftijd < 4)
            {
                Console.WriteLine("Tweede kleuterklas");
            }
            else
            {
                Console.WriteLine("Derde kleuterklas");
            }
        }
    }
}
