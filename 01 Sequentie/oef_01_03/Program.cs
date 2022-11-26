using System;

namespace oef_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            double aantalVolwassenen, aantalKinderen, prijs;

            // waarden inlezen
            Console.WriteLine("Geef het aantal volwassenen:");
            aantalVolwassenen = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef het aantal kinderen:");
            aantalKinderen = int.Parse(Console.ReadLine());

            // berekeningen
            prijs = 10 * aantalVolwassenen + 7.5 * aantalKinderen;

            // resultaat afdrukken
            Console.WriteLine($"Totaal te betalen: {prijs} euro");
        }
    }
}
