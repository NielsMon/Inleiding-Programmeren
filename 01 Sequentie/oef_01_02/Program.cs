using System;

namespace oef_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            double prijsExcl, prijsIncl, btwPerc;

            // waarden inlezen
            prijsExcl = double.Parse(Console.ReadLine());
            btwPerc = double.Parse(Console.ReadLine());

            // berekening maken
            prijsIncl = (1 + (btwPerc/100)) * prijsExcl;

            // resultaat afdrukken
            Console.WriteLine($"Prijs inclusief BTW: {prijsIncl}");
        }
    }
}
