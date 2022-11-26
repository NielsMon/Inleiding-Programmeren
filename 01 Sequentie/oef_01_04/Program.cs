using System;

namespace oef_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            double bedragExcl, bedragIncl, aantalInt, aantalNat;

            // waarden opvragen
            aantalInt = double.Parse(Console.ReadLine());
            aantalNat = double.Parse(Console.ReadLine());

            // berekeningen
            bedragExcl = 23 + ((aantalNat + aantalInt) * 0.12);
            bedragIncl = (1.21 * bedragExcl);

            // resultaat printen
            Console.WriteLine($"Totaal te betalen: {bedragIncl} euro");
        }
    }
}
