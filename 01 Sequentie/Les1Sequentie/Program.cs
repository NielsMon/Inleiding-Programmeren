using System;

namespace MyApp // Note: actual namespace depends on the project name. 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// schermkleuren aanpassen
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Clear(); // update kleuren gebeurd pas na Console.Clear()
			Console.Title = "Les 1";
			
			// ons eerste programma
			Console.WriteLine("Hallo toekomstige C# ontwikkelaar!");

            // wachten op enter
            Console.WriteLine();
            Console.WriteLine("Druk op enter om verder te gaan!");
			Console.ReadLine();

			Console.Clear();

			// declaratie van variabelen
			string voornaam;
			int getal;
			double teBetalenBedrag;

			// basiswaarde toekennen
			string boodschap = "";
			double kortingPercentage = 0.05;
			bool isGevonden = false;

            Console.WriteLine("Lees 4 getallen in");

			// inlezen van 4 getallen
			int getal1 = Convert.ToInt32(Console.ReadLine());
			int getal2 = int.Parse(Console.ReadLine());
			int getal3 = int.Parse(Console.ReadLine());
			int getal4 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Rekenkundige bewerkingen");
            Console.WriteLine($"getal1++: {getal1++}");
			Console.WriteLine($"++getal2: {++getal2}");
			Console.WriteLine($"getal3--: {getal3--}");
			Console.WriteLine($"--getal4: {--getal4}");

            Console.WriteLine();

            Console.WriteLine($"Math.Pow(5,2)= {Math.Pow(5,2)}");
			Console.WriteLine($"Math.Sqrt(16)= {Math.Sqrt(16)}");

			// wachten op enter
			Console.WriteLine();
			Console.WriteLine("Druk op enter om verder te gaan!");
			Console.ReadLine();

			Console.Clear();

            // resultaten drukken
            Console.Write("Mijn naam is Niels, ");
            Console.WriteLine("mijn achernaam is Mondelaers.");

			// wachten op enter
			Console.WriteLine();
			Console.WriteLine("Druk op enter om verder te gaan!");
			Console.ReadLine();

			Console.Clear();
		}
	}
}