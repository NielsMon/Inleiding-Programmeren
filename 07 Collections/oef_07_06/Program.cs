using System;
using System.Collections.Generic;
using System.Linq;

namespace oef_07_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scherminstellingen aanpassen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 7: Oefening 6";

            // Variabelen declareren
            List<int> list = new List<int>();

            string input = ReserveerZitplaats();

            while (input.ToLower() != "stop")
            {
                bool isDubbel = false;
                int getal = int.Parse(input);
                foreach (var item in list)
                {
                    if (getal == item)
                    {
                        isDubbel = true;
                    }
                }
                
                if (!isDubbel)
                {
                    list.Add(getal);
                }
                input = ReserveerZitplaats();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            


            // Programma afsluiten
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
        private static string ReserveerZitplaats()
        {
            bool success = false;
            string input;
            int plaats;
            do
            {
                Console.Write("Reserveer plaats: ");
                input= Console.ReadLine();
                success = int.TryParse((input), out plaats);
                if (input.ToLower() == "stop")
                {
                    success = true;
                }
                else if (plaats < 1 || plaats > 40)
                {
                    Console.WriteLine("Deze zitplaats bestaat niet!");
                    success = false;
                }
            } while (!success);

            return input;
        }
    }
}
