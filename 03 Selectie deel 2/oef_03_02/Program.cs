using System;

namespace oef_03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een jaartal: ");
            int jaar = int.Parse(Console.ReadLine());

            string resultaat;
            if (jaar > 1582 && jaar % 4000 == 0)
            {
                resultaat = "geen schrikkeljaar";
            }
            else if (jaar > 1582 && jaar % 400 == 0)
            {
                resultaat = "een schrikkeljaar";
            }
            else if (jaar > 1582 && jaar % 100 == 0)
            {
                resultaat = "geen schrikkeljaar";
            }
            else if (jaar > 1582 && jaar % 4 == 0)
            {
                resultaat = "een schrikkeljaar";
            }
            else if (jaar < 1582 && jaar % 4 == 0)
            {
                resultaat = "een schrikkeljaar";
            }
            else
            {
                resultaat = "geen schrikkeljaar";
            }

            Console.WriteLine($"{jaar} is {resultaat}");
        }
    }
}
