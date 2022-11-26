using System;

namespace Les_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaratie variabelen
            string activiteit, smsAntwoord, persoon;
            bool benJeVrij;
            DateTime datumUurActiviteit;

            PasSchermkleurAan();
            DrukTitel();
            activiteit = LeesActiviteit("\tVoor welke activietiet kreeg je een sms bericht (stop = geen)? ");
            while (activiteit.ToLower() != "geen")
            {
                datumUurActiviteit = LeesDatumUur(activiteit);
                benJeVrij = LeesBenJeVrij(datumUurActiviteit);
                persoon = LeesPersoon();
                smsAntwoord = BepaalAntwoord(persoon, benJeVrij);
                DrukAntwoord(datumUurActiviteit, smsAntwoord);
                activiteit = LeesActiviteit("\tVoor welke activieteit kreeg je nog een sms-bericht (stop = geen)? ");
            }
            DrukEnter();            
        }
        private static void PasSchermkleurAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 8 - " + DateTime.Now.ToLongDateString() + " " +
                DateTime.Now.ToShortTimeString();
        }
        private static void DrukTitel()
        {
            Console.WriteLine("\tOntvangen SMS-bericht\n");
        }
        private static string LeesActiviteit(string vraag)
        {
            string invoer;

            do
            {
                Console.Write(vraag);
                invoer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(invoer));

            return invoer;
        }
        private static DateTime LeesDatumUur(string activiteit)
        {
            DateTime datumUur;
            string invoer;

            do
            {
                Console.WriteLine("\tGeef datum en uur dat \"{0}\" zal doorgaan? ", activiteit);
                invoer = Console.ReadLine();
            } while (DateTime.TryParse(invoer, out datumUur) == false ||
            datumUur < DateTime.Now);

            return datumUur;
        }
        private static bool LeesBenJeVrij(DateTime datumUur)
        {
            bool isVrij;
            string invoer;

            do
            {
                Console.Write("\tBen je vrij op {0} ('true' of 'false')? ", datumUur);
                invoer=Console.ReadLine();
            } while (!bool.TryParse(invoer, out isVrij));

            return isVrij;
        }
        private static string LeesPersoon()
        {
            string invoer;

            do
            {
                Console.Write("\tVan wie was het smsje? ");
                invoer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(invoer));

            return invoer;
        }
        private static string BepaalAntwoord(string naam, bool isVrij)
        {
            string antwoord = naam.ToUpper();

            if(isVrij == true)
            {
                antwoord += ", ik zal er zijn!";
            }
            else
            {
                antwoord += ", spijtig, het zal voor een andere keer zijn!";
            }

            return antwoord;
        }
        private static void DrukAntwoord(DateTime datumUur, string antwoord)
        {
            Console.WriteLine("\n\tOp {0} om {1} - {2}\n", datumUur.ToLongDateString(),
                datumUur.ToShortTimeString(),antwoord);
        }
        private static void DrukEnter()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
