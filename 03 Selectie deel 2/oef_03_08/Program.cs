using System;

namespace oef_03_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());

            string antwoord;
            if (getal % 2 == 0)
            {
                antwoord = "Even, ";

                if (getal % 5 == 0)
                {
                    antwoord += "deelbaar door 5.";
                }
                else
                {
                    antwoord += "niet deelbaar door 5.";
                }
            }
            else
            {
                antwoord = "Oneven, ";

                if (getal % 7 == 0)
                {
                    antwoord += "deelbaar door 7.";
                }
                else
                {
                    antwoord += "niet deelbaar door 7.";
                }
            }

            Console.WriteLine(antwoord);
        }
    }
}
