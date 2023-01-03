using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string woord = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(woord))
            {
                list.Add(woord);
                woord = Console.ReadLine();
            }

            list.Sort();
            Console.WriteLine("\n");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine(list.First().Length);
            Console.WriteLine(list.Last().Length);
        }
        private static string GeefGetal()
        {
            int getal;
            string input, output;
            bool succes = false;
            do
            {
                Console.Write("Geef getal: ");
                input = Console.ReadLine();
                succes = int.TryParse(input, out getal);
                if (string.IsNullOrWhiteSpace(input))
                {
                    succes = true;
                }
            } while (!succes);
             output = String.IsNullOrWhiteSpace(input) ? null : getal.ToString();
            return output;
        }
    }
}