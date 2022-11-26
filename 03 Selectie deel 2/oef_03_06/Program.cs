using System;

namespace oef_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal van 1 tem 7!");
            int getal = int.Parse(Console.ReadLine());

            string dag;
            switch (getal)
            {
                case 1: dag = "maandag"; break;
                case 2: dag = "dinsdag"; break;
                case 3: dag = "woensdag"; break;
                case 4: dag = "donderdag"; break;
                case 5: dag = "vrijdag"; break;
                case 6: dag = "zaterdag"; break;
                case 7: dag = "zondag"; break;
                default: dag = "Foutieve invoer"; break;
            }
            Console.WriteLine(dag);
        }
    }
}
