using System;
using System.Collections.Generic;
using System.IO;

namespace vb_examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();
            Console.WriteLine("E-mail controle:");
            ControleerBestand("emails.txt");

            Console.WriteLine("\nCovid:");
            List<string> menu = new List<string>();
            menu.Add("0 - Stop");
            menu.Add("1 - Maandtotaal opvragen");
            menu.Add("2 - Jaartotaal opvragen");

            List<string> menuSubkeuze = new List<string>();
            menuSubkeuze.Add("0: Aantal besmettingen");
            menuSubkeuze.Add("1: Aantal sterfgevallen");

            foreach (var item in menu)
            {
                Console.WriteLine(item);
            }

            int menuKeuze = LeesGetal(0, 2);
            while (menuKeuze != 0)
            {
                int som = 0;
                if (menuKeuze == 1)
                {
                    Console.WriteLine("Selecteer een maand:");
                    int maand = LeesGetal(1, 12);
                    Console.WriteLine("Submenu:");
                    foreach (var item in menuSubkeuze)
                    {
                        Console.WriteLine(item);
                    }
                    int subkeuze = LeesGetal(0, 1);
                    som = BehandelBestand(subkeuze, maand);
                    Drukresultaat(subkeuze, som);
                }
                else
                {
                    Console.WriteLine("Submenu:");
                    foreach (var item in menuSubkeuze)
                    {
                        Console.WriteLine(item);
                    }
                    int subkeuze = LeesGetal(0, 1);
                    for (int i = 1; i <= 12; i++)
                    {
                        som += BehandelBestand(subkeuze, i);
                    }
                    Drukresultaat(subkeuze,som);
                }
                DrukOpEnter();
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }

                menuKeuze = LeesGetal(0, menu.Count - 1);
            }
            DrukOpEnter();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "r0772240 - Niels Mondelaers - Emailcontrole";
        }
        private static void DrukOpEnter()
        {
            Console.WriteLine("\nDruk op enter om door te gaan");
            Console.ReadLine();
        }
        private static void ControleerBestand(string bestandsnaam)
        {
            if (File.Exists(bestandsnaam))
            {
                int counter = 0;
                List<string> emails = new List<string>();
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        counter++;
                        emails.Add(record);
                    }
                    Console.WriteLine($"Totaal: {counter}");
                    Console.WriteLine($"Correct: {TelCorrecte(emails)}");
                    Console.WriteLine($"Incorrect: {TelIncorrecte(emails)}");
                }
            }
            else
            {
                Console.WriteLine($"Bestandsnaam: {bestandsnaam}\n{bestandsnaam} bestaat niet");
            }
        }
        private static bool ControleerRecord(string record)
        {
            bool isGeldig = false;
            foreach (var item in record)
            {
                if (item == '@')
                {
                    isGeldig = true;
                }
            }
            return isGeldig;
        }
        private static int TelCorrecte(List<string> emails)
        {
            int correcte = 0;
            for (int i = 0; i < emails.Count; i++)
            {
                if (ControleerRecord(emails[i]))
                {
                    correcte++;
                }
            }
            return correcte;
        }
        private static int TelIncorrecte(List<string> emails)
        {
            int inCorrecte = 0;
            for (int i = 0; i < emails.Count; i++)
            {
                if (!ControleerRecord(emails[i]))
                {
                    inCorrecte++;
                }
            }
            return inCorrecte;
        }
        private static int LeesGetal(int min, int max)
        {
            string input;
            int getal;
            do
            {
                Console.Write($"Lees een getal in tussen {min} en {max}: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < min || getal > max);
            return getal;
        }
        private static int BehandelBestand(int subkeuze, int maand)
        {
            int som = 0;
            string bestandsnaam = $"{maand}.txt";
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader teLezenBestand = new StreamReader(bestandsnaam))
                {
                    while (!teLezenBestand.EndOfStream)
                    {
                        string record = teLezenBestand.ReadLine();
                        string[] array = record.Split(';');
                        som = subkeuze == 0 ? som += int.Parse(array[0]) : som += int.Parse(array[1]);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
            return som;
        }
        private static void Drukresultaat(int subkeuze, int waarde)
        {
            string keuze = subkeuze == 0 ? "besmettingen" : "sterfgevallen";
            Console.WriteLine($"Totaal aantal {keuze}: {waarde}");
        }
    }
}
