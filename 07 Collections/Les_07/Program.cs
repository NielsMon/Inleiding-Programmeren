using System;
using System.Collections.Generic;
using System.Linq;

namespace Les_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string titel = "Les O7: Collections";
            Console.Title = titel;
            Console.WriteLine(titel);
            Console.WriteLine(new string('_', titel.Length));

            // Arrays
            Console.WriteLine("\nArrays");
            Console.WriteLine(new string('_', "arrays".Length));
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            int tweedeGetal = numbers[1];

            string[] namen = { "Niels", "Jolien", "Emma", "Thomas", "Louise" };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 3)
                {
                    Console.WriteLine($"3 is gevonden op plaats {i+1}!");
                }
            }

            Console.WriteLine("\nNamen:");
            foreach (var naam in namen)
            {
                Console.WriteLine(naam);
            }

            Console.WriteLine("\nList");
            Console.WriteLine(new string('_', "list".Length));

            List<int> getallen = new List<int>();
            getallen.Add(5);
            getallen.Add(6);
            getallen.Add(7);
            getallen.Add(8);
            getallen.Add(9);
            getallen.Add(10);

            List<string> list = new List<string> { "Roger", "Niels" };
            list.Add("Peggy");

            Console.WriteLine("\nNamen:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(getallen.First());

            //Console.WriteLine(getallen.First());
            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
