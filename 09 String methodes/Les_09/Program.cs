using System;

namespace Les_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasSchermkleurenAan();

            // substring
            string woord = "letter";

            Console.WriteLine("SUBSTRING()");
            Console.WriteLine("\nSubstring(startpositie, aantal)");
            for (int i = 0; i < woord.Length; i++)
            {
                string letter = woord.Substring(i, 1);
                Console.WriteLine("Letter: " + letter);
            }

            Console.WriteLine("\nSubstring(startpositie)");
            for (int i = 0; i < woord.Length; i++)
            {
                string woorddeel = woord.Substring(i);
                Console.WriteLine($"Vanaf positie {i}: {woorddeel}");
            }

            // insert
            Console.WriteLine("\nINSERT()");
            Console.WriteLine("\nInsert(startpositie, string)");
            string extra = "s of cijfers?";
            Console.WriteLine(woord.Insert(woord.Length, extra));

            // replace
            Console.WriteLine("\nREPLACE()");
            Console.WriteLine("\nReplace(oud karakter, nieuw karakter)");
            Console.WriteLine(woord.Replace("t", "g"));

            // trim
            string woordTrim = "     Jef Klabas     ";
            Console.WriteLine("\nTRIM()");
            Console.WriteLine($"*{woordTrim}*");
            Console.WriteLine($"*{woordTrim.Trim()}*");
            Console.WriteLine($"*{woordTrim.TrimStart()}*");
            Console.WriteLine($"*{woordTrim.TrimEnd()}*");

            // padleft
            Console.WriteLine("\nPADLEFT()/PADRIGHT()");
            Console.WriteLine("\n" + woord.PadLeft(30));
            Console.WriteLine(woord.PadLeft(30, '-'));
            Console.WriteLine(woord.PadRight(30));
            Console.WriteLine(woord.PadRight(30, '-'));

            // indexof
            Console.WriteLine("\nINDEXOF()");
            Console.WriteLine($"letter.IndexOf(t): {woord.IndexOf("t")}");
            Console.WriteLine($"letter.IndexOf(l): {woord.IndexOf("l")}");
            Console.WriteLine($"letter.IndexOf(a): {woord.IndexOf("a")}");

            // lastindexof
            Console.WriteLine("\nLASTINDEXOF()");
            Console.WriteLine($"letter.LastIndexOf(t): {woord.LastIndexOf("t")}");
            Console.WriteLine($"letter.LastIndexOf(t, 2): {woord.LastIndexOf("t", 2)}");

            StopProgramma();
        }
        private static void PasSchermkleurenAan()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Les 09: STRING METHODES";
        }
        private static void StopProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
