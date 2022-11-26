using System;

namespace oef_03_10
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

            int middel;
            if (getal1 > getal2)
            {
                if (getal1 < getal3)
                    middel = getal1;
                else if (getal2 > getal3)
                    middel = getal2;
                else
                    middel = getal3;
            }
            else
            {
                if (getal1 > getal3)
                    middel = getal1;
                else if (getal2 < getal3)
                    middel = getal2;
                else
                    middel = getal3;
            }

            Console.WriteLine("Middelste getal: {0}", middel);
        }
    }
}
