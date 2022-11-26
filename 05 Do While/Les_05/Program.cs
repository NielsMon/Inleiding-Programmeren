using System;

namespace Les_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 05: Do While";

            Console.WriteLine("Les 05: Do While");
            Console.WriteLine("________________");
            Console.WriteLine("\n5 standaardvragen:");
            Console.WriteLine("\t1. Welke info moeten we inlezen?");
            Console.WriteLine("\t2. Welke info tonen we aan de gebruiker?");
            Console.WriteLine("\t3. Welke info heeft een variabele nodig?");
            Console.WriteLine("\t4. Welke beserkingen zijn nodig?");
            Console.WriteLine("\t5. Is er gegevenscontrole nodig?");

            Console.WriteLine("\nVoorbeeld 1: " + DateTime.Now.ToLongDateString()
                + " " + DateTime.Now.ToShortTimeString());

            // Declaratie variabelen
            string activiteit, invoer, smsAntwoord;
            bool benJeVrij;
            DateTime datumUurActiviteit;
            int getal;
            double bedrag;

            Console.WriteLine("DateTime voorbeelden:");
            Console.WriteLine("\t{0}", DateTime.Now.ToLongDateString());
            Console.WriteLine("\t{0}", DateTime.Now.ToShortDateString());
            Console.WriteLine("\t{0}", DateTime.Now.ToLongTimeString());
            Console.WriteLine("\t{0}", DateTime.Now.ToShortTimeString());
            Console.WriteLine("\t{0}", DateTime.Now.AddDays(5));
            Console.WriteLine("\t{0}", DateTime.Now.Year);

            // Data inlezen
            Console.WriteLine("\nOntvangen SMS bericht");

            // Gegevenscontrole activiteit
            do
            {
                Console.Write("\tVoor welke activiteit kreeg je een sms-bericht? ");
                activiteit = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(activiteit));

            // Gegevenscontrole datum en tijd
            do
            {
                do
                {
                    Console.Write($"\tGeef datum en uur dat \"{activiteit}\" zal doorgaan! ");
                    invoer = Console.ReadLine();
                } while (DateTime.TryParse(invoer, out datumUurActiviteit) == false);
            } while (datumUurActiviteit<DateTime.Now);

            // Gegevenscontrole ben je vrij
            do
            {
                Console.Write($"\tBen je vrij op {invoer} ('true' of 'false')? ");
                invoer= Console.ReadLine();
            } while (!bool.TryParse(invoer, out benJeVrij));

            // Bewerkingen uitvoeren
            if (benJeVrij == true)
            {
                smsAntwoord = "Ik zal er zijn!";
            }
            else
            {
                smsAntwoord = "Spijtig, het zal voor een andere keer zijn!";
            }

            // Resultaat tonen
            Console.WriteLine($"\n\tOp {datumUurActiviteit.ToLongDateString()} om " +
                $"{datumUurActiviteit.ToShortTimeString()} - {smsAntwoord}");

            // Willekeurige getallen oproepen
            Random rand = new Random();

            Console.WriteLine("\nRandom():");
            Console.WriteLine($"\tWillekeurig: {rand.Next()}");
            Console.WriteLine($"\tBovengrens: {rand.Next(5)}");
            Console.WriteLine($"\tOnder- en bovengrens: {rand.Next(1, 10)}");

            // String eigenschappen
            Console.WriteLine("\nString eigenschappen:");
            string naam = "Jef Klabas";
            string letter = "B";
            string voorwerp = "potlood";

            Console.WriteLine(naam);
            Console.WriteLine(new string('_', naam.Length));
            Console.WriteLine(letter);
            Console.WriteLine(new string('*', letter.Length));
            Console.WriteLine(voorwerp);
            Console.WriteLine(new string('=', voorwerp.Length));

            // Programma beëindigen
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
