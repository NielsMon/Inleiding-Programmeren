using System;

namespace oef_01_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            int korteZijde, langeZijde;

            // waarden inlezen
            korteZijde = int.Parse(Console.ReadLine());
            langeZijde = int.Parse(Console.ReadLine());

            // berekeningen
            int omtrek = (2 * korteZijde) + (2 * langeZijde);
            int oppervlakte = korteZijde * langeZijde;

            // berekeningen afdrukken
            Console.WriteLine($"Omtrek: {omtrek}");
            Console.WriteLine($"Oppervlakte: {oppervlakte}");

            Console.ReadLine();
        }
    }
}
